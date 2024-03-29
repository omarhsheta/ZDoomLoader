﻿namespace ZDoomLoader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            engine_label = new Label();
            wads_label = new Label();
            engine_input = new TextBox();
            engine_button = new Button();
            pwad_list = new CheckedListBox();
            pwad_button = new Button();
            run_button = new Button();
            select_button = new Button();
            unselect_button = new Button();
            SuspendLayout();
            // 
            // engine_label
            // 
            engine_label.AutoSize = true;
            engine_label.Location = new Point(15, 65);
            engine_label.Name = "engine_label";
            engine_label.Size = new Size(376, 15);
            engine_label.TabIndex = 0;
            engine_label.Text = "Supported Engines: GZDoom, ZDoom, Zandronum, and QZandronum";
            // 
            // wads_label
            // 
            wads_label.AutoSize = true;
            wads_label.Location = new Point(12, 138);
            wads_label.Name = "wads_label";
            wads_label.Size = new Size(82, 15);
            wads_label.TabIndex = 1;
            wads_label.Text = "Doom PWADs";
            // 
            // engine_input
            // 
            engine_input.Enabled = false;
            engine_input.Location = new Point(12, 39);
            engine_input.Name = "engine_input";
            engine_input.Size = new Size(597, 23);
            engine_input.TabIndex = 2;
            // 
            // engine_button
            // 
            engine_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            engine_button.Location = new Point(681, 39);
            engine_button.Name = "engine_button";
            engine_button.Size = new Size(94, 23);
            engine_button.TabIndex = 3;
            engine_button.Text = "Find Engine";
            engine_button.UseVisualStyleBackColor = true;
            engine_button.Click += engine_button_Click;
            // 
            // pwad_list
            // 
            pwad_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pwad_list.FormattingEnabled = true;
            pwad_list.Location = new Point(15, 166);
            pwad_list.Name = "pwad_list";
            pwad_list.Size = new Size(760, 220);
            pwad_list.TabIndex = 4;
            // 
            // pwad_button
            // 
            pwad_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pwad_button.Location = new Point(681, 134);
            pwad_button.Name = "pwad_button";
            pwad_button.Size = new Size(94, 23);
            pwad_button.TabIndex = 5;
            pwad_button.Text = "Add PWAD";
            pwad_button.UseVisualStyleBackColor = true;
            pwad_button.Click += pwad_button_Click;
            // 
            // run_button
            // 
            run_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            run_button.Location = new Point(701, 413);
            run_button.Name = "run_button";
            run_button.Size = new Size(75, 23);
            run_button.TabIndex = 6;
            run_button.Text = "Run Doom!";
            run_button.UseVisualStyleBackColor = true;
            run_button.Click += run_button_Click;
            // 
            // select_button
            // 
            select_button.Location = new Point(15, 415);
            select_button.Name = "select_button";
            select_button.Size = new Size(86, 23);
            select_button.TabIndex = 7;
            select_button.Text = "Select All";
            select_button.UseVisualStyleBackColor = true;
            select_button.Click += select_button_Click;
            // 
            // unselect_button
            // 
            unselect_button.Location = new Point(107, 415);
            unselect_button.Name = "unselect_button";
            unselect_button.Size = new Size(86, 23);
            unselect_button.TabIndex = 8;
            unselect_button.Text = "Unselect All";
            unselect_button.UseVisualStyleBackColor = true;
            unselect_button.Click += unselect_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(unselect_button);
            Controls.Add(select_button);
            Controls.Add(run_button);
            Controls.Add(pwad_button);
            Controls.Add(pwad_list);
            Controls.Add(engine_button);
            Controls.Add(engine_input);
            Controls.Add(wads_label);
            Controls.Add(engine_label);
            Name = "Form1";
            Text = "ZDoomLoader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label engine_label;
        private Label wads_label;
        private TextBox engine_input;
        private Button engine_button;
        private CheckedListBox pwad_list;
        private Button pwad_button;
        private Button run_button;
        private Button select_button;
        private Button unselect_button;
    }
}
