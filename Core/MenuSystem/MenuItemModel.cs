using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace CorelXTools.Core.MenuSystem
{
    /// <summary>
    /// 工具菜单数据模型
    /// 用于描述 CorelXTools 的工具按钮
    /// </summary>
    public class MenuItemModel
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 图标路径
        /// </summary>
        public string Icon { get; set; }


        /// <summary>
        /// 工具描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 所属分类
        /// 例如：图片工具、矢量工具
        /// </summary>
        public string Category { get; set; }


        /// <summary>
        /// 点击执行命令
        /// </summary>
        public ICommand Command { get; set; }

        /// <summary>
        /// 功能唯一编号
        /// 用于打开对应模块
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        public List<MenuItemModel> Children { get; set; }
            = new List<MenuItemModel>();


        public MenuItemModel()
        {

        }
    }
}