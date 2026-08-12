using DBEngine.Editor.UI;
using UnityEditor;  

public static class DBEngineUISettingsProvider  
{  
    [MenuItem("DBEngine/Settings/DBEngineUISettings", priority = -1)]
    public static void OpenSettings() => SettingsService.OpenProjectSettings("Project/DBEngine/UISettings");
    
    private const string SettingsPath = "Project/DBEngine/UISettings";  

    [SettingsProvider]  
    public static SettingsProvider CreateMySettingsProvider()  
    {  
        return new SettingsProvider(SettingsPath, SettingsScope.Project)  
        {  
            label = "DBEngine/UISettings",  
            guiHandler = (searchContext) =>  
            {  
                var scriptGeneratorSetting = ScriptGeneratorSetting.Instance;  
                var scriptGenerator = new SerializedObject(scriptGeneratorSetting);  

                EditorGUILayout.PropertyField(scriptGenerator.FindProperty("_codePath"));  
                EditorGUILayout.PropertyField(scriptGenerator.FindProperty("_namespace"));  
                EditorGUILayout.PropertyField(scriptGenerator.FindProperty("_widgetName"));  
                EditorGUILayout.PropertyField(scriptGenerator.FindProperty("CodeStyle"));  
                EditorGUILayout.PropertyField(scriptGenerator.FindProperty("scriptGenerateRule"));  
                scriptGenerator.ApplyModifiedProperties();
            },  
            keywords = new[] { "DBEngine", "Settings", "Custom" }  
        };  
    }
}  
