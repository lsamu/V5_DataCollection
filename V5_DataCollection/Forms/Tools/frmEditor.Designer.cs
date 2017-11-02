namespace V5_DataCollection.Forms.Tools {
    partial class frmEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_RunScript = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ScriptSave = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_RunScript,
            this.toolStripButton_ScriptSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_RunScript
            // 
            this.toolStripButton_RunScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_RunScript.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RunScript.Image")));
            this.toolStripButton_RunScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RunScript.Name = "toolStripButton_RunScript";
            this.toolStripButton_RunScript.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_RunScript.Text = "≤‚ ‘";
            this.toolStripButton_RunScript.Click += new System.EventHandler(this.toolStripButton_RunScript_Click);
            // 
            // toolStripButton_ScriptSave
            // 
            this.toolStripButton_ScriptSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_ScriptSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ScriptSave.Image")));
            this.toolStripButton_ScriptSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ScriptSave.Name = "toolStripButton_ScriptSave";
            this.toolStripButton_ScriptSave.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_ScriptSave.Text = "±£¥Ê";
            this.toolStripButton_ScriptSave.Click += new System.EventHandler(this.toolStripButton_ScriptSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 411);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 104);
            this.textBox1.TabIndex = 2;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 28);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Size = new System.Drawing.Size(658, 377);
            this.fastColoredTextBox1.TabIndex = 3;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 527);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEditor";
            this.Text = "frmEditor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_RunScript;
        private System.Windows.Forms.ToolStripButton toolStripButton_ScriptSave;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}