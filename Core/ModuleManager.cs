using CorelXTools.Modules.Export;
using CorelXTools.UI;


namespace CorelXTools.Core
{
    public static class ModuleManager
    {


        public static void Open(string action)
        {


            switch (action)
            {


                case "Export":


                    ToolWindow window = new ToolWindow();


                    window.SetTitle("批量导出");


                    window.Width = 450;

                    window.Height = 350;


                    // 加载功能模块
                    window.SetContent(
                        new ExportTool()
                    );


                    window.Show();


                    break;


            }


        }


    }
}