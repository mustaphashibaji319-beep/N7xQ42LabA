using System.Collections.Generic;

namespace CorelXTools.Core.MenuSystem
{
    /// <summary>
    /// 菜单提供者
    /// 统一管理所有工具
    /// </summary>
    public static class MenuProvider
    {

        /// <summary>
        /// 获取主工具菜单
        /// </summary>
        public static List<MenuItemModel> GetMainMenu()
        {
            return new List<MenuItemModel>
            {

                new MenuItemModel()
{
    Name = "图片工具",
    Category = "Image",
    Description = "图片处理相关工具",

    Children =
    {
        new MenuItemModel()
        {
            Name="批量导出",
            Description="批量导出图片",
            Action="Export"
        },

        new MenuItemModel()
        {
            Name="图片压缩",
            Description="图片大小优化"
        },

        new MenuItemModel()
        {
            Name="CMYK转换",
            Description="颜色模式转换"
        }
    }
},


                new MenuItemModel()
                {
                    Name = "矢量工具",
                    Category = "Vector",
                    Description = "CorelDRAW矢量处理工具"
                },


                new MenuItemModel()
                {
                    Name = "批量工具",
                    Category = "Batch",
                    Description = "批量自动化处理"
                },


                new MenuItemModel()
                {
                    Name = "印刷工具",
                    Category = "Print",
                    Description = "印刷辅助功能"
                },


                new MenuItemModel()
                {
                    Name = "模板工具",
                    Category = "Template",
                    Description = "模板管理"
                },


                new MenuItemModel()
                {
                    Name = "AI工具",
                    Category = "AI",
                    Description = "人工智能辅助工具"
                }

            };
        }

    }
}