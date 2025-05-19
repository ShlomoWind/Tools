using System.Collections.Generic;

public class ToolBox
{
    List<Tool> toolBox = new List<Tool>();
    public void AddTool(Tool tool)
    {
        toolBox.Add(tool);
    }
    public void PrintList()
    {
        foreach (Tool t in toolBox)
        {
            t.GetName();
        }
    }
}