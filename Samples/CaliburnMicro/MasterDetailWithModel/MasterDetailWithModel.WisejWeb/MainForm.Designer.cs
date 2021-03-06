﻿namespace MasterDetailWithModel
{
    partial class MainForm
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new Wisej.Web.MenuBar();
            this.fileMenu = new Wisej.Web.MenuItem();
            this.openStudentList1 = new Wisej.Web.MenuItem();
            this.openStudentList2 = new Wisej.Web.MenuItem();
            this.fileMenuSeparator = new Wisej.Web.MenuItem();
            this.closeStudentList = new Wisej.Web.MenuItem();
            this.exit = new Wisej.Web.MenuItem();
            this.studentMenu = new Wisej.Web.MenuItem();
            this.createStudent = new Wisej.Web.MenuItem();
            this.saveStudent = new Wisej.Web.MenuItem();
            this.deleteStudent = new Wisej.Web.MenuItem();
            this.closeStudent = new Wisej.Web.MenuItem();
            this.statusBar = new Wisej.Web.StatusBar();
            this.placeHolder = new Wisej.Web.StatusBarPanel();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = Wisej.Web.DockStyle.Top;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.fileMenu,
            this.studentMenu});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(832, 22);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStop = false;
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.openStudentList1,
            this.openStudentList2,
            this.fileMenuSeparator,
            this.closeStudentList,
            this.exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Text = "File";
            // 
            // openStudentList1
            // 
            this.openStudentList1.Index = 0;
            this.openStudentList1.Name = "openStudentList1";
            this.openStudentList1.Text = "Open student list (method 1)";
            // 
            // openStudentList2
            // 
            this.openStudentList2.Index = 1;
            this.openStudentList2.Name = "openStudentList2";
            this.openStudentList2.Text = "Open student list (method 2)";
            // 
            // fileMenuSeparator
            // 
            this.fileMenuSeparator.Index = 2;
            this.fileMenuSeparator.Name = "fileMenuSeparator";
            this.fileMenuSeparator.Text = "-";
            // 
            // closeStudentList
            // 
            this.closeStudentList.Index = 3;
            this.closeStudentList.Name = "closeStudentList";
            this.closeStudentList.Text = "Close student list";
            // 
            // exit
            // 
            this.exit.Index = 4;
            this.exit.Name = "exit";
            this.exit.Text = "Exit";
            // 
            // studentMenu
            // 
            this.studentMenu.Index = 1;
            this.studentMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.createStudent,
            this.saveStudent,
            this.deleteStudent,
            this.closeStudent});
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Text = "Student";
            // 
            // createStudent
            // 
            this.createStudent.Index = 0;
            this.createStudent.Name = "createStudent";
            this.createStudent.Text = "New student";
            // 
            // saveStudent
            // 
            this.saveStudent.Index = 1;
            this.saveStudent.Name = "saveStudent";
            this.saveStudent.Text = "Save student";
            // 
            // deleteStudent
            // 
            this.deleteStudent.Index = 2;
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Text = "Delete student";
            // 
            // closeStudent
            // 
            this.closeStudent.Index = 3;
            this.closeStudent.Name = "closeStudent";
            this.closeStudent.Text = "Close student form";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 478);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new Wisej.Web.StatusBarPanel[] {
            this.placeHolder});
            this.statusBar.Size = new System.Drawing.Size(832, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // placeHolder
            // 
            this.placeHolder.AutoSize = Wisej.Web.StatusBarPanelAutoSize.Spring;
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Text = null;
            // 
            // activeItem
            // 
            this.activeItem.Dock = Wisej.Web.DockStyle.Fill;
            this.activeItem.Location = new System.Drawing.Point(0, 22);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(832, 456);
            this.activeItem.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(832, 500);
            this.ClientSize = new System.Drawing.Size(796, 434);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.MenuBar mainMenu;
        private Wisej.Web.MenuItem fileMenu;
        private Wisej.Web.MenuItem openStudentList1;
        private Wisej.Web.MenuItem openStudentList2;
        private Wisej.Web.MenuItem fileMenuSeparator;
        private Wisej.Web.MenuItem closeStudentList;
        private Wisej.Web.MenuItem exit;
        private Wisej.Web.MenuItem studentMenu;
        private Wisej.Web.MenuItem createStudent;
        private Wisej.Web.MenuItem saveStudent;
        private Wisej.Web.MenuItem deleteStudent;
        private Wisej.Web.MenuItem closeStudent;
        private Wisej.Web.StatusBar statusBar;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
        private Wisej.Web.StatusBarPanel placeHolder;
    }
}

