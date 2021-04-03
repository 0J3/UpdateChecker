
namespace TestAutoUpdater
{
  partial class Updater
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
      this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.Title = new System.Windows.Forms.Label();
      this.Description = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.Close = new Siticone.UI.WinForms.SiticoneButton();
      this.UpdateBtn = new Siticone.UI.WinForms.SiticoneButton();
      this.CloseAlt = new Siticone.UI.WinForms.SiticoneButton();
      this.SuspendLayout();
      // 
      // bunifuDragControl1
      // 
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = this;
      this.bunifuDragControl1.Vertical = true;
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.ForeColor = System.Drawing.Color.White;
      this.Title.Location = new System.Drawing.Point(9, 9);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(258, 37);
      this.Title.TabIndex = 0;
      this.Title.Text = "Checking for Updates";
      this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Description
      // 
      this.Description.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Description.ForeColor = System.Drawing.Color.White;
      this.Description.Location = new System.Drawing.Point(12, 59);
      this.Description.Name = "Description";
      this.Description.Size = new System.Drawing.Size(255, 49);
      this.Description.TabIndex = 1;
      this.Description.Text = "This may take a small amount of time";
      // 
      // bunifuDragControl2
      // 
      this.bunifuDragControl2.Fixed = true;
      this.bunifuDragControl2.Horizontal = true;
      this.bunifuDragControl2.TargetControl = this.Description;
      this.bunifuDragControl2.Vertical = true;
      // 
      // bunifuDragControl3
      // 
      this.bunifuDragControl3.Fixed = true;
      this.bunifuDragControl3.Horizontal = true;
      this.bunifuDragControl3.TargetControl = this.Title;
      this.bunifuDragControl3.Vertical = true;
      // 
      // Close
      // 
      this.Close.CheckedState.Parent = this.Close;
      this.Close.CustomImages.Parent = this.Close;
      this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Close.ForeColor = System.Drawing.Color.White;
      this.Close.HoveredState.Parent = this.Close;
      this.Close.Location = new System.Drawing.Point(-1, 139);
      this.Close.Name = "Close";
      this.Close.ShadowDecoration.Parent = this.Close;
      this.Close.Size = new System.Drawing.Size(142, 45);
      this.Close.TabIndex = 2;
      this.Close.Text = "Close";
      this.Close.Visible = false;
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // UpdateBtn
      // 
      this.UpdateBtn.CheckedState.Parent = this.UpdateBtn;
      this.UpdateBtn.CustomImages.Parent = this.UpdateBtn;
      this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.UpdateBtn.ForeColor = System.Drawing.Color.White;
      this.UpdateBtn.HoveredState.Parent = this.UpdateBtn;
      this.UpdateBtn.Location = new System.Drawing.Point(142, 139);
      this.UpdateBtn.Name = "UpdateBtn";
      this.UpdateBtn.ShadowDecoration.Parent = this.UpdateBtn;
      this.UpdateBtn.Size = new System.Drawing.Size(142, 45);
      this.UpdateBtn.TabIndex = 3;
      this.UpdateBtn.Text = "Go to Update Page";
      this.UpdateBtn.Visible = false;
      this.UpdateBtn.Click += new System.EventHandler(this.SiticoneButton1_Click);
      // 
      // CloseAlt
      // 
      this.CloseAlt.CheckedState.Parent = this.CloseAlt;
      this.CloseAlt.CustomImages.Parent = this.CloseAlt;
      this.CloseAlt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.CloseAlt.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.CloseAlt.ForeColor = System.Drawing.Color.White;
      this.CloseAlt.HoveredState.Parent = this.CloseAlt;
      this.CloseAlt.Location = new System.Drawing.Point(-1, 139);
      this.CloseAlt.Name = "CloseAlt";
      this.CloseAlt.ShadowDecoration.Parent = this.CloseAlt;
      this.CloseAlt.Size = new System.Drawing.Size(285, 45);
      this.CloseAlt.TabIndex = 4;
      this.CloseAlt.Text = "Close";
      this.CloseAlt.Visible = false;
      this.CloseAlt.Click += new System.EventHandler(this.SiticoneButton1_Click_1);
      // 
      // Updater
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
      this.ClientSize = new System.Drawing.Size(284, 184);
      this.Controls.Add(this.CloseAlt);
      this.Controls.Add(this.UpdateBtn);
      this.Controls.Add(this.Close);
      this.Controls.Add(this.Description);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Updater";
      this.Text = "Auto Updater";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuCustomLabel Description;
    private System.Windows.Forms.Label Title;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    private Siticone.UI.WinForms.SiticoneButton UpdateBtn;
    private Siticone.UI.WinForms.SiticoneButton Close;
    private Siticone.UI.WinForms.SiticoneButton CloseAlt;
  }
}

