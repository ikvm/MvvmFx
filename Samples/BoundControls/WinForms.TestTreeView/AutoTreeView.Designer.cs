﻿namespace WinForms.TestTreeView
{
    partial class AutoTreeView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTreeView));
            this.buttonView = new System.Windows.Forms.Button();
            this.textboxView = new System.Windows.Forms.TextBox();
            this.textboxModel = new System.Windows.Forms.TextBox();
            this.buttonModel = new System.Windows.Forms.Button();
            this.boundTreeView1 = new MvvmFx.Controls.WinForms.BoundTreeView();
            this.leafListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.leafName = new System.Windows.Forms.Label();
            this.dragDropStatusLabel = new System.Windows.Forms.Label();
            this.leafId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leafParentId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.readOnlyAllowSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.readOnlyAllowDragCheckBox = new System.Windows.Forms.CheckBox();
            this.readOnlyAllowDropCheckBox = new System.Windows.Forms.CheckBox();
            this.collapseButton = new System.Windows.Forms.Button();
            this.allowDropOnDescendentsCheckBox = new System.Windows.Forms.CheckBox();
            this.allowDropOnRootCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxSelectValue = new System.Windows.Forms.TextBox();
            this.selectValueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafListBindingSource)).BeginInit();
            this.SuspendLayout();
            //
            // buttonView
            //
            this.buttonView.Location = new System.Drawing.Point(249, 101);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(84, 23);
            this.buttonView.TabIndex = 19;
            this.buttonView.Text = "Set View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.tvButtonView_Click);
            //
            // textboxView
            //
            this.textboxView.Location = new System.Drawing.Point(249, 78);
            this.textboxView.Name = "textboxView";
            this.textboxView.Size = new System.Drawing.Size(100, 20);
            this.textboxView.TabIndex = 18;
            //
            // textboxModel
            //
            this.textboxModel.Location = new System.Drawing.Point(249, 13);
            this.textboxModel.Name = "textboxModel";
            this.textboxModel.Size = new System.Drawing.Size(100, 20);
            this.textboxModel.TabIndex = 17;
            //
            // buttonModel
            //
            this.buttonModel.Location = new System.Drawing.Point(249, 36);
            this.buttonModel.Name = "buttonModel";
            this.buttonModel.Size = new System.Drawing.Size(84, 23);
            this.buttonModel.TabIndex = 16;
            this.buttonModel.Text = "Set Model";
            this.buttonModel.UseVisualStyleBackColor = true;
            this.buttonModel.Click += new System.EventHandler(this.tvButtonModel_Click);
            //
            // leafListBindingSource
            //
            this.leafListBindingSource.DataSource = typeof(BoundControls.Business.LeafList);
            this.bindingSourceRefresh.SetReadValuesOnChange(this.leafListBindingSource, true);
            //
            // boundTreeView1
            //
            this.boundTreeView1.AllowDrop = true;
            //this.boundTreeView1.DataSource = this.leafListBindingSource;
            this.boundTreeView1.DisplayMember = "LeafName";
            this.boundTreeView1.DuplicatedCaption = "Duplicated Identifier Error";
            this.boundTreeView1.DuplicatedMessage = "Node \"{0}\" duplicates identifier \"{1}\"";
            this.boundTreeView1.GeneralNodeError = "Error at node.";
            this.boundTreeView1.HideSelection = false;
            this.boundTreeView1.HotTracking = true;
            this.boundTreeView1.IdentifierMember = "LeafId";
            this.boundTreeView1.ImageIndex = 0;
            this.boundTreeView1.ImageList = this.imageList;
            this.boundTreeView1.InexistentParent = "Parent of node does not exist.";
            this.boundTreeView1.LabelEdit = true;
            this.boundTreeView1.Location = new System.Drawing.Point(16, 13);
            this.boundTreeView1.Name = "boundTreeView1";
            this.boundTreeView1.ParentIdentifierMember = "LeafParentId";
            this.boundTreeView1.ReadOnlyImageIndex = 2;
            this.boundTreeView1.ReadOnlyMember = "LeafIsReadOnly";
            this.boundTreeView1.ReadOnlySelectedImageIndex = 3;
            this.boundTreeView1.SelectedImageIndex = 1;
            this.boundTreeView1.SelfParent = "Parent of node cannot be the node itself.";
            this.boundTreeView1.ShowNodeToolTips = true;
            this.boundTreeView1.Size = new System.Drawing.Size(212, 394);
            this.boundTreeView1.Sorted = false;
            this.boundTreeView1.TabIndex = 15;
            this.boundTreeView1.ToolTipTextMember = "LeafDescription";
            this.boundTreeView1.ValueMember = "LeafId";
            this.boundTreeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.boundTreeView1_AfterLabelEdit);
            this.boundTreeView1.BindingContextChanged += new System.EventHandler(this.boundTreeView1_BindingContextChanged);
            this.boundTreeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.boundTreeView1_DragDrop);
            this.boundTreeView1.SelectedValueChanged += new System.EventHandler(this.boundTreeView1_SelectedValueChanged);
            //
            // imageList
            //
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Node.png");
            this.imageList.Images.SetKeyName(1, "NodeSelected.png");
            this.imageList.Images.SetKeyName(2, "ReadOnlyNode.png");
            this.imageList.Images.SetKeyName(3, "ReadOnlyNodeSelected.png");
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Leaf Name:";
            //
            // leafName
            //
            this.leafName.Location = new System.Drawing.Point(661, 66);
            this.leafName.Name = "leafName";
            this.leafName.Size = new System.Drawing.Size(100, 13);
            this.leafName.TabIndex = 21;
            this.leafName.Text = "Leaf Name";
            //
            // dragDropStatusLabel
            //
            this.dragDropStatusLabel.Location = new System.Drawing.Point(543, 216);
            this.dragDropStatusLabel.Name = "dragDropStatusLabel";
            this.dragDropStatusLabel.Size = new System.Drawing.Size(200, 13);
            this.dragDropStatusLabel.TabIndex = 28;
            this.dragDropStatusLabel.Text = "Current Drag&&Drop Status";
            //
            // leafId
            //
            this.leafId.Location = new System.Drawing.Point(664, 104);
            this.leafId.Name = "leafId";
            this.leafId.Size = new System.Drawing.Size(100, 13);
            this.leafId.TabIndex = 30;
            this.leafId.Text = "Leaf Id";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Leaf Id:";
            //
            // leafParentId
            //
            this.leafParentId.Location = new System.Drawing.Point(666, 143);
            this.leafParentId.Name = "leafParentId";
            this.leafParentId.Size = new System.Drawing.Size(100, 13);
            this.leafParentId.TabIndex = 32;
            this.leafParentId.Text = "Leaf Parent Id";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Leaf Parent Id:";
            //
            // refreshButton
            //
            this.refreshButton.Location = new System.Drawing.Point(249, 261);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(84, 23);
            this.refreshButton.TabIndex = 33;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            //
            // sortButton
            //
            this.sortButton.Location = new System.Drawing.Point(249, 300);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(84, 23);
            this.sortButton.TabIndex = 33;
            this.sortButton.Text = "Sort";
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            //
            // expandButton
            //
            this.expandButton.Location = new System.Drawing.Point(249, 343);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(84, 23);
            this.expandButton.TabIndex = 33;
            this.expandButton.Text = "Expand";
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            //
            // readOnlyAllowSelectCheckBox
            //
            this.readOnlyAllowSelectCheckBox.AutoSize = true;
            this.readOnlyAllowSelectCheckBox.Location = new System.Drawing.Point(249, 142);
            this.readOnlyAllowSelectCheckBox.Name = "readOnlyAllowSelectCheckBox";
            this.readOnlyAllowSelectCheckBox.Size = new System.Drawing.Size(134, 17);
            this.readOnlyAllowSelectCheckBox.TabIndex = 34;
            this.readOnlyAllowSelectCheckBox.Text = "ReadOnly Allow Select";
            this.readOnlyAllowSelectCheckBox.CheckedChanged += new System.EventHandler(this.readOnlyAllowSelectCheckBox_CheckedChanged);
            //
            // readOnlyAllowDragCheckBox
            //
            this.readOnlyAllowDragCheckBox.AutoSize = true;
            this.readOnlyAllowDragCheckBox.Location = new System.Drawing.Point(249, 159);
            this.readOnlyAllowDragCheckBox.Name = "readOnlyAllowDragCheckBox";
            this.readOnlyAllowDragCheckBox.Size = new System.Drawing.Size(127, 17);
            this.readOnlyAllowDragCheckBox.TabIndex = 34;
            this.readOnlyAllowDragCheckBox.Text = "ReadOnly Allow Drag";
            this.readOnlyAllowDragCheckBox.CheckedChanged += new System.EventHandler(this.readOnlyAllowDragCheckBox_CheckedChanged);
            //
            // readOnlyAllowDropCheckBox
            //
            this.readOnlyAllowDropCheckBox.AutoSize = true;
            this.readOnlyAllowDropCheckBox.Location = new System.Drawing.Point(249, 176);
            this.readOnlyAllowDropCheckBox.Name = "readOnlyAllowDropCheckBox";
            this.readOnlyAllowDropCheckBox.Size = new System.Drawing.Size(127, 17);
            this.readOnlyAllowDropCheckBox.TabIndex = 34;
            this.readOnlyAllowDropCheckBox.Text = "ReadOnly Allow Drop";
            this.readOnlyAllowDropCheckBox.CheckedChanged += new System.EventHandler(this.readOnlyAllowDropCheckBox_CheckedChanged);
            //
            // collapseButton
            //
            this.collapseButton.Location = new System.Drawing.Point(249, 384);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(84, 23);
            this.collapseButton.TabIndex = 33;
            this.collapseButton.Text = "Collapse";
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            //
            // allowDropOnDescendentsCheckBox
            //
            this.allowDropOnDescendentsCheckBox.AutoSize = true;
            this.allowDropOnDescendentsCheckBox.Location = new System.Drawing.Point(249, 192);
            this.allowDropOnDescendentsCheckBox.Name = "allowDropOnDescendentsCheckBox";
            this.allowDropOnDescendentsCheckBox.Size = new System.Drawing.Size(127, 17);
            this.allowDropOnDescendentsCheckBox.TabIndex = 35;
            this.allowDropOnDescendentsCheckBox.Text = "Allow Drop On Descendents";
            this.allowDropOnDescendentsCheckBox.CheckedChanged += new System.EventHandler(this.allowDropOnDescendentsCheckBox_CheckedChanged);
            //
            // allowDropOnRootCheckBox
            //
            this.allowDropOnRootCheckBox.AutoSize = true;
            this.allowDropOnRootCheckBox.Location = new System.Drawing.Point(249, 208);
            this.allowDropOnRootCheckBox.Name = "allowDropOnRootCheckBox";
            this.allowDropOnRootCheckBox.Size = new System.Drawing.Size(127, 17);
            this.allowDropOnRootCheckBox.TabIndex = 35;
            this.allowDropOnRootCheckBox.Text = "Allow Drop On Root";
            this.allowDropOnRootCheckBox.CheckedChanged += new System.EventHandler(this.allowDropOnRootCheckBox_CheckedChanged);
            //
            // textBoxSelectValue
            //
            this.textBoxSelectValue.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.textBoxSelectValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSelectValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSelectValue.Location = new System.Drawing.Point(546, 264);
            this.textBoxSelectValue.Name = "textBoxSelectValue";
            this.textBoxSelectValue.Size = new System.Drawing.Size(84, 20);
            this.textBoxSelectValue.TabIndex = 37;
            //
            // selectValueButton
            //
            this.selectValueButton.Location = new System.Drawing.Point(546, 287);
            this.selectValueButton.Name = "selectValueButton";
            this.selectValueButton.Size = new System.Drawing.Size(84, 23);
            this.selectValueButton.TabIndex = 36;
            this.selectValueButton.Text = "Select Value";
            this.selectValueButton.UseVisualStyleBackColor = true;
            this.selectValueButton.Click += new System.EventHandler(this.selectValueButton_Click);
            //
            // AutoTreeView
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.textBoxSelectValue);
            this.Controls.Add(this.selectValueButton);
            this.Controls.Add(this.allowDropOnRootCheckBox);
            this.Controls.Add(this.allowDropOnDescendentsCheckBox);
            this.Controls.Add(this.collapseButton);
            this.Controls.Add(this.readOnlyAllowDropCheckBox);
            this.Controls.Add(this.readOnlyAllowDragCheckBox);
            this.Controls.Add(this.readOnlyAllowSelectCheckBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.leafParentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leafId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dragDropStatusLabel);
            this.Controls.Add(this.leafName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.textboxView);
            this.Controls.Add(this.textboxModel);
            this.Controls.Add(this.buttonModel);
            //this.Controls.Add(this.boundTreeView1);
            this.MaximumSize = new System.Drawing.Size(931, 438);
            this.MinimumSize = new System.Drawing.Size(931, 438);
            this.Name = "AutoTreeView";
            this.Size = new System.Drawing.Size(931, 438);
            this.Text = "AutoTreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.TextBox textboxView;
        private System.Windows.Forms.TextBox textboxModel;
        private System.Windows.Forms.Button buttonModel;
        private MvvmFx.Controls.WinForms.BoundTreeView boundTreeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leafName;
        private System.Windows.Forms.Label dragDropStatusLabel;
        private System.Windows.Forms.Label leafId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label leafParentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.CheckBox readOnlyAllowSelectCheckBox;
        private System.Windows.Forms.CheckBox readOnlyAllowDragCheckBox;
        private System.Windows.Forms.CheckBox readOnlyAllowDropCheckBox;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.CheckBox allowDropOnDescendentsCheckBox;
        private System.Windows.Forms.CheckBox allowDropOnRootCheckBox;
        private System.Windows.Forms.BindingSource leafListBindingSource;
        private System.Windows.Forms.TextBox textBoxSelectValue;
        private System.Windows.Forms.Button selectValueButton;
    }
}