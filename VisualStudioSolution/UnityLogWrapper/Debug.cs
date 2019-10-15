using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Internal;

/// <summary>
/// Class containing methods to ease debugging while developing a game.
/// Methods are called only if "LOGGING" define is added to Scripting Define Symbols in Player Settings.
/// </summary>
public sealed class Debug
{
    private const string LOGGING = "LOGGING";
    private const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

    /// <summary>
    /// Reports whether the development console is visible.
    /// The development console cannot be made to appear using:
    /// </summary>
    public static bool developerConsoleVisible
    {
        get { return UnityEngine.Debug.developerConsoleVisible; }
        set { UnityEngine.Debug.developerConsoleVisible = value; }
    }

    /// <summary>
    /// In the Build Settings dialog there is a check box called "Development Build".
    /// </summary>
    public static bool isDebugBuild
    {
        get { return UnityEngine.Debug.isDebugBuild; }
    }

    /// <summary>
    /// Get default debug logger.
    /// </summary>
    public static ILogger logger
    {
        get { return UnityEngine.Debug.logger; }
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition)
    {
        UnityEngine.Debug.Assert(condition);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition, string message)
    {
        UnityEngine.Debug.Assert(condition, message);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition, object message)
    {
        UnityEngine.Debug.Assert(condition, message);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, context);
    }

    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition, string message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, message, context);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void Assert(bool condition, object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, message, context);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, format, args);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void AssertFormat(bool condition, UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, context, format, args);
    }

    /// <summary>
    /// Pauses the editor.
    /// </summary>
    [Conditional(LOGGING)]
    public static void Break()
    {
        UnityEngine.Debug.Break();
    }

    /// <summary>
    /// Clears errors from the developer console.
    /// </summary>
    [Conditional(LOGGING)]
    public static void ClearDeveloperConsole()
    {
        UnityEngine.Debug.ClearDeveloperConsole();
    }

    [Conditional(LOGGING)]
    public static void DebugBreak()
    {
        UnityEngine.Debug.DebugBreak();
    }

    /// <summary>
    /// Draws a line between specified start and end points.
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawLine(Vector3 start, Vector3 end)
    {
        UnityEngine.Debug.DrawLine(start, end);
    }

    /// <summary>
    /// Draws a line between specified start and end points.
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawLine(Vector3 start, Vector3 end, Color color)
    {
        UnityEngine.Debug.DrawLine(start, end, color);
    }

    /// <summary>
    /// Draws a line between specified start and end points.
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration);
    }

    /// <summary>
    /// Draws a line between specified start and end points.
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
    [Conditional(LOGGING)]
    public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    /// <summary>
    /// Draws a line from start to start + dir in world coordinates.
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawRay(Vector3 start, Vector3 dir)
    {
        UnityEngine.Debug.DrawRay(start, dir);
    }

    /// <summary>
    /// Draws a line from start to start + dir in world coordinates.
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color)
    {
        UnityEngine.Debug.DrawRay(start, dir, color);
    }

    /// <summary>
    /// Draws a line from start to start + dir in world coordinates.
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    [ExcludeFromDocs]
    [Conditional(LOGGING)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
    {
        UnityEngine.Debug.DrawRay(start, dir, color, duration);
    }

    /// <summary>
    /// Draws a line from start to start + dir in world coordinates.
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
    [Conditional(LOGGING)]
    public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
    {
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    /// <summary>
    /// Logs message to the Unity Console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING)]
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(message);
    }

    /// <summary>
    /// Logs message to the Unity Console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING)]
    public static void Log(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Log(message, context);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an assertion message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void LogAssertion(object message)
    {
        UnityEngine.Debug.LogAssertion(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an assertion message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void LogAssertion(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogAssertion(message, context);
    }

    /// <summary>
    /// Logs a formatted assertion message to the Unity console.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void LogAssertionFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted assertion message to the Unity console.
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING), Conditional(UNITY_ASSERTIONS)]
    public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING)]
    public static void LogError(object message)
    {
        UnityEngine.Debug.LogError(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING)]
    public static void LogError(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogError(message, context);
    }

    /// <summary>
    /// Logs a formatted error message to the Unity console.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogErrorFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted error message to the Unity console.
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <param name="exception">Runtime Exception.</param>
    [Conditional(LOGGING)]
    public static void LogException(Exception exception)
    {
        UnityEngine.Debug.LogException(exception);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <param name="exception">Runtime Exception.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING)]
    public static void LogException(Exception exception, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogException(exception, context);
    }

    /// <summary>
    /// Logs a formatted message to the Unity Console.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted message to the Unity Console.
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs a warning message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGGING)]
    public static void LogWarning(object message)
    {
        UnityEngine.Debug.LogWarning(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs a warning message to the console.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGGING)]
    public static void LogWarning(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogWarning(message, context);
    }

    /// <summary>
    /// Logs a formatted warning message to the Unity Console.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogWarningFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted warning message to the Unity Console.
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGGING)]
    public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(context, format, args);
    }
}
