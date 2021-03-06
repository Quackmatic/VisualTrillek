﻿namespace VisualTrillek
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemView = new System.Windows.Forms.MenuItem();
            this.menuItemEvents = new System.Windows.Forms.MenuItem();
            this.menuItemWelcome = new System.Windows.Forms.MenuItem();
            this.menuItemTools = new System.Windows.Forms.MenuItem();
            this.menuItemPlugins = new System.Windows.Forms.MenuItem();
            this.menuItemWindow = new System.Windows.Forms.MenuItem();
            this.menuItemMaximise = new System.Windows.Forms.MenuItem();
            this.menuItemMinimise = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItemCascade = new System.Windows.Forms.MenuItem();
            this.menuItemArrangeIcons = new System.Windows.Forms.MenuItem();
            this.menuItemTileH = new System.Windows.Forms.MenuItem();
            this.menuItemTileV = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemView,
            this.menuItemTools,
            this.menuItemWindow,
            this.menuItem2});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItem3,
            this.menuItemExit});
            this.menuItemFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 0;
            this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 1;
            this.menuItemOpen.MergeOrder = 1;
            this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItemOpen.Text = "&Open...";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MergeOrder = 20;
            this.menuItem3.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.MergeOrder = 21;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 1;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemEvents,
            this.menuItemWelcome});
            this.menuItemView.MergeOrder = 20;
            this.menuItemView.Text = "&View";
            // 
            // menuItemEvents
            // 
            this.menuItemEvents.Index = 0;
            this.menuItemEvents.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItemEvents.Text = "&Events...";
            this.menuItemEvents.Click += new System.EventHandler(this.menuItemEvents_Click);
            // 
            // menuItemWelcome
            // 
            this.menuItemWelcome.Index = 1;
            this.menuItemWelcome.Shortcut = System.Windows.Forms.Shortcut.AltF1;
            this.menuItemWelcome.Text = "&Welcome...";
            this.menuItemWelcome.Click += new System.EventHandler(this.menuItemWelcome_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.Index = 2;
            this.menuItemTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemPlugins});
            this.menuItemTools.MergeOrder = 22;
            this.menuItemTools.Text = "&Tools";
            // 
            // menuItemPlugins
            // 
            this.menuItemPlugins.Index = 0;
            this.menuItemPlugins.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuItemPlugins.Text = "&Plugins...";
            this.menuItemPlugins.Click += new System.EventHandler(this.menuItemPlugins_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.Index = 3;
            this.menuItemWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemMaximise,
            this.menuItemMinimise,
            this.menuItem8,
            this.menuItemCascade,
            this.menuItemArrangeIcons,
            this.menuItemTileH,
            this.menuItemTileV,
            this.menuItem5});
            this.menuItemWindow.MergeOrder = 23;
            this.menuItemWindow.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemMaximise
            // 
            this.menuItemMaximise.Index = 0;
            this.menuItemMaximise.Shortcut = System.Windows.Forms.Shortcut.AltUpArrow;
            this.menuItemMaximise.Text = "Toggle &Maximise";
            this.menuItemMaximise.Click += new System.EventHandler(this.menuItemMaximise_Click);
            // 
            // menuItemMinimise
            // 
            this.menuItemMinimise.Index = 1;
            this.menuItemMinimise.Shortcut = System.Windows.Forms.Shortcut.AltDownArrow;
            this.menuItemMinimise.Text = "Toggle Minimi&se";
            this.menuItemMinimise.Click += new System.EventHandler(this.menuItemMinimise_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // menuItemCascade
            // 
            this.menuItemCascade.Index = 3;
            this.menuItemCascade.Text = "&Cascade";
            this.menuItemCascade.Click += new System.EventHandler(this.menuItemCascade_Click);
            // 
            // menuItemArrangeIcons
            // 
            this.menuItemArrangeIcons.Index = 4;
            this.menuItemArrangeIcons.Text = "&Arrange Icons";
            this.menuItemArrangeIcons.Click += new System.EventHandler(this.menuItemArrangeIcons_Click);
            // 
            // menuItemTileH
            // 
            this.menuItemTileH.Index = 5;
            this.menuItemTileH.Text = "Tile &Horizontal";
            this.menuItemTileH.Click += new System.EventHandler(this.menuItemTileH_Click);
            // 
            // menuItemTileV
            // 
            this.menuItemTileV.Index = 6;
            this.menuItemTileV.Text = "Tile &Vertical";
            this.menuItemTileV.Click += new System.EventHandler(this.menuItemTileV_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 7;
            this.menuItem5.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem2.MergeOrder = 24;
            this.menuItem2.Text = "&Help";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "&About...";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 513);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(653, 22);
            this.statusBar.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 535);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.Name = "Main";
            this.Text = "Visual Trillek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemNew;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.MenuItem menuItemCascade;
        private System.Windows.Forms.MenuItem menuItemArrangeIcons;
        private System.Windows.Forms.MenuItem menuItemTileH;
        private System.Windows.Forms.MenuItem menuItemTileV;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemEvents;
        internal System.Windows.Forms.MenuItem menuItemWindow;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemWelcome;
        private System.Windows.Forms.MenuItem menuItemMaximise;
        private System.Windows.Forms.MenuItem menuItemMinimise;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItemTools;
        private System.Windows.Forms.MenuItem menuItemPlugins;




    }
}

