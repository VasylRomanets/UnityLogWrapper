# LogWrapper
Solution for stripping logs from builds.

# Tl;dr
'Debug' class that wraps 'UnityEngine.Debug'. Logs appear only if 'LOGGING' define is added to *Scripting Define Symbols*. If you want to disable just specified class logs add ```#undef LOGGING``` at the top of the class.

# Problem
All the 'UnityEngine.Debug' methods are executed in release builds. Sometimes this may cause a noticeable performance overhead especially when your game is running on some low-end device such as old Android smartphone.

Possible solution for this problem is wrapping all debug calls with preprocessor directives like this:

```cs
#if UNITY_EDITOR
Debug.Log("This message appears only in editor!");
#endif
```
But what if you have hundreds or even thousands of calls? Then it's quite a big amount of work. You may also use plugins in your project. Some calls may be inside your plugin assembly. In most cases you can't handle such calls because you don't have assembly source code.

Next thought that comes to mind is creating a wrapper debug class. This solution also has a flaw. In the Editor, you lose the feature of double clicking logs and jumping directly to the original place where the debug call was issued, since you'll now end up in your new debug class all the time. This is a major time waste.

# Solution
It's high time for working solution. I created a class that wraps all the public members of 'UnityEngine.Debug' class and moved it to a separate assembly. In this case double click ignores all stack frames on the top not from the current assembly so you're navigated to a proper class. I gave it the name 'Debug' and left it in global namespace. This means all calls to 'Debug' class in your project will lead to the wrapper class. The only exception is the calls where 'UnityEngine' namespace is specified:

```cs
UnityEngine.Debug.Log("This call doesn't lead to the wrapper class!");
```

Remove 'UnityEngine.' part to get rid of this call. This is the only breakable change of your code. In all other cases you don't nead to change anything.

So why calls aren't executed? The answer is that all methods have 'Conditional' attribute above their declaration:
```cs
[Conditional("LOGGING")]
public static void Log(object message)
{
    UnityEngine.Debug.Log(message);
}
```

Thus, methods are executed only if 'LOGGING' define is added to *Scripting Define Symbols*. In the Editor go to *Edit/Project Settings/Player* and select *Other Settings* tab. Type 'LOGGING' in the textbox under the *Scripting Define Symbols* and don't forget to press enter:

![Alt text](https://github.com/VasylRomanets/UnityLogWrapper/blob/images/LOGGING.png?raw=true "Scripting Define Symbols")

Keep in mind that only methods can be marked with 'Conditional' attribute. This means that properties are still executable.

If you want to disable just specified class logs add ```#undef LOGGING``` at the top of your class.

# Installation
Just drop 'UnityLogWrapper' folder to your project's 'Assets' folder.

# Recompiling assembly
If you want to edit and recompile the visual studio solution you should add reference to 'UnityEngine.dll'. In your VS go to *Project/Add Reference/Browse* and select 'UnityEngine.dll'. On Windows, the path will typically be *C:\Program Files\Unity\Editor\Data\Managed*.
You must also set some properties in *Project/UnityLogWrapper properties...*. On the 'Application' tab under the 'Target framework:' select '.NET Framework 3.5'. Add 'UnityLogWrapper' to 'Default namespace:'. Then go to 'Build' tab and check 'XML documentation file:' checkbox. This step is needed to show method commentaries via IntelliSense. Generated xml-file must be in the same folder with dll-file. Now you can build the solution.
