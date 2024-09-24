
namespace WSLManager
{
    partial class Frm_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbx_MainControl = new System.Windows.Forms.GroupBox();
            this.Btn_GetWSL = new System.Windows.Forms.Button();
            this.Tbc_Main = new System.Windows.Forms.TabControl();
            this.Tbp_LocalSet = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LSV_Distro = new System.Windows.Forms.ListView();
            this.Clm_DistroName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_DistroState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_DistroWSLVer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gbx_MainControl.SuspendLayout();
            this.Tbc_Main.SuspendLayout();
            this.Tbp_LocalSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_MainControl
            // 
            this.Gbx_MainControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_MainControl.Controls.Add(this.Btn_GetWSL);
            this.Gbx_MainControl.Location = new System.Drawing.Point(6, 6);
            this.Gbx_MainControl.Name = "Gbx_MainControl";
            this.Gbx_MainControl.Size = new System.Drawing.Size(787, 120);
            this.Gbx_MainControl.TabIndex = 0;
            this.Gbx_MainControl.TabStop = false;
            this.Gbx_MainControl.Text = "Main";
            // 
            // Btn_GetWSL
            // 
            this.Btn_GetWSL.Location = new System.Drawing.Point(21, 24);
            this.Btn_GetWSL.Name = "Btn_GetWSL";
            this.Btn_GetWSL.Size = new System.Drawing.Size(166, 35);
            this.Btn_GetWSL.TabIndex = 0;
            this.Btn_GetWSL.Text = "Get Distro On WSL";
            this.Btn_GetWSL.UseVisualStyleBackColor = true;
            this.Btn_GetWSL.Click += new System.EventHandler(this.Btn_GetWSL_Click);
            // 
            // Tbc_Main
            // 
            this.Tbc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbc_Main.Controls.Add(this.Tbp_LocalSet);
            this.Tbc_Main.Controls.Add(this.tabPage2);
            this.Tbc_Main.Location = new System.Drawing.Point(12, 12);
            this.Tbc_Main.Name = "Tbc_Main";
            this.Tbc_Main.SelectedIndex = 0;
            this.Tbc_Main.Size = new System.Drawing.Size(807, 426);
            this.Tbc_Main.TabIndex = 1;
            // 
            // Tbp_LocalSet
            // 
            this.Tbp_LocalSet.Controls.Add(this.LSV_Distro);
            this.Tbp_LocalSet.Controls.Add(this.Gbx_MainControl);
            this.Tbp_LocalSet.Location = new System.Drawing.Point(4, 25);
            this.Tbp_LocalSet.Name = "Tbp_LocalSet";
            this.Tbp_LocalSet.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_LocalSet.Size = new System.Drawing.Size(799, 397);
            this.Tbp_LocalSet.TabIndex = 0;
            this.Tbp_LocalSet.Text = "WSL Local Manage";
            this.Tbp_LocalSet.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LSV_Distro
            // 
            this.LSV_Distro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LSV_Distro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clm_DistroName,
            this.Clm_DistroState,
            this.Clm_DistroWSLVer});
            this.LSV_Distro.HideSelection = false;
            this.LSV_Distro.Location = new System.Drawing.Point(6, 132);
            this.LSV_Distro.Name = "LSV_Distro";
            this.LSV_Distro.Size = new System.Drawing.Size(490, 259);
            this.LSV_Distro.TabIndex = 1;
            this.LSV_Distro.UseCompatibleStateImageBehavior = false;
            this.LSV_Distro.View = System.Windows.Forms.View.Details;
            // 
            // Clm_DistroName
            // 
            this.Clm_DistroName.Text = "Name";
            // 
            // Clm_DistroState
            // 
            this.Clm_DistroState.Text = "State";
            // 
            // Clm_DistroWSLVer
            // 
            this.Clm_DistroWSLVer.Text = "Version";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.Tbc_Main);
            this.Name = "Frm_Main";
            this.Text = "WSL Manager V1.0";
            this.Gbx_MainControl.ResumeLayout(false);
            this.Tbc_Main.ResumeLayout(false);
            this.Tbp_LocalSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_MainControl;
        private System.Windows.Forms.Button Btn_GetWSL;
        private System.Windows.Forms.TabControl Tbc_Main;
        private System.Windows.Forms.TabPage Tbp_LocalSet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView LSV_Distro;
        private System.Windows.Forms.ColumnHeader Clm_DistroName;
        private System.Windows.Forms.ColumnHeader Clm_DistroState;
        private System.Windows.Forms.ColumnHeader Clm_DistroWSLVer;
    }
}

