namespace GetOAuthToken
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTenantId = new System.Windows.Forms.TextBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxClientSecret = new System.Windows.Forms.TextBox();
            this.buttonGetCredential = new System.Windows.Forms.Button();
            this.labelAccessTokenData = new System.Windows.Forms.Label();
            this.labelTenantId = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelClientSecret = new System.Windows.Forms.Label();
            this.labelTokenType = new System.Windows.Forms.Label();
            this.labelTokenTypeData = new System.Windows.Forms.Label();
            this.labelExpiresIn = new System.Windows.Forms.Label();
            this.labelExpiresInData = new System.Windows.Forms.Label();
            this.labelNotBefore = new System.Windows.Forms.Label();
            this.labelNotBeforeData = new System.Windows.Forms.Label();
            this.labelExpiresOn = new System.Windows.Forms.Label();
            this.labelExpiresOnData = new System.Windows.Forms.Label();
            this.labelAccessToken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTenantId
            // 
            this.textBoxTenantId.Location = new System.Drawing.Point(37, 91);
            this.textBoxTenantId.Name = "textBoxTenantId";
            this.textBoxTenantId.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenantId.TabIndex = 1;
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(37, 35);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientId.TabIndex = 0;
            // 
            // textBoxClientSecret
            // 
            this.textBoxClientSecret.Location = new System.Drawing.Point(37, 147);
            this.textBoxClientSecret.Name = "textBoxClientSecret";
            this.textBoxClientSecret.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientSecret.TabIndex = 2;
            // 
            // buttonGetCredential
            // 
            this.buttonGetCredential.Location = new System.Drawing.Point(37, 253);
            this.buttonGetCredential.Name = "buttonGetCredential";
            this.buttonGetCredential.Size = new System.Drawing.Size(124, 23);
            this.buttonGetCredential.TabIndex = 3;
            this.buttonGetCredential.Text = "Get Token";
            this.buttonGetCredential.UseVisualStyleBackColor = true;
            this.buttonGetCredential.Click += new System.EventHandler(this.buttonGetCredential_Click);
            // 
            // labelAccessTokenData
            // 
            this.labelAccessTokenData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccessTokenData.Location = new System.Drawing.Point(180, 237);
            this.labelAccessTokenData.Name = "labelAccessTokenData";
            this.labelAccessTokenData.Size = new System.Drawing.Size(591, 117);
            this.labelAccessTokenData.TabIndex = 4;
            this.labelAccessTokenData.Text = "Your token will be shown here!";
            this.labelAccessTokenData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAccessTokenData.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelTenantId
            // 
            this.labelTenantId.AutoSize = true;
            this.labelTenantId.Location = new System.Drawing.Point(37, 72);
            this.labelTenantId.Name = "labelTenantId";
            this.labelTenantId.Size = new System.Drawing.Size(53, 13);
            this.labelTenantId.TabIndex = 5;
            this.labelTenantId.Text = "Tenant Id";
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(37, 19);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(45, 13);
            this.labelClientId.TabIndex = 6;
            this.labelClientId.Text = "Client Id";
            // 
            // labelClientSecret
            // 
            this.labelClientSecret.AutoSize = true;
            this.labelClientSecret.Location = new System.Drawing.Point(37, 131);
            this.labelClientSecret.Name = "labelClientSecret";
            this.labelClientSecret.Size = new System.Drawing.Size(67, 13);
            this.labelClientSecret.TabIndex = 7;
            this.labelClientSecret.Text = "Client Secret";
            // 
            // labelTokenType
            // 
            this.labelTokenType.AutoSize = true;
            this.labelTokenType.Location = new System.Drawing.Point(180, 23);
            this.labelTokenType.Name = "labelTokenType";
            this.labelTokenType.Size = new System.Drawing.Size(68, 13);
            this.labelTokenType.TabIndex = 8;
            this.labelTokenType.Text = "Token Type:";
            // 
            // labelTokenTypeData
            // 
            this.labelTokenTypeData.AutoSize = true;
            this.labelTokenTypeData.Location = new System.Drawing.Point(180, 42);
            this.labelTokenTypeData.Name = "labelTokenTypeData";
            this.labelTokenTypeData.Size = new System.Drawing.Size(13, 13);
            this.labelTokenTypeData.TabIndex = 9;
            this.labelTokenTypeData.Text = "_";
            // 
            // labelExpiresIn
            // 
            this.labelExpiresIn.AutoSize = true;
            this.labelExpiresIn.Location = new System.Drawing.Point(180, 70);
            this.labelExpiresIn.Name = "labelExpiresIn";
            this.labelExpiresIn.Size = new System.Drawing.Size(56, 13);
            this.labelExpiresIn.TabIndex = 10;
            this.labelExpiresIn.Text = "Expires In:";
            this.labelExpiresIn.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelExpiresInData
            // 
            this.labelExpiresInData.AutoSize = true;
            this.labelExpiresInData.Location = new System.Drawing.Point(180, 91);
            this.labelExpiresInData.Name = "labelExpiresInData";
            this.labelExpiresInData.Size = new System.Drawing.Size(13, 13);
            this.labelExpiresInData.TabIndex = 11;
            this.labelExpiresInData.Text = "_";
            // 
            // labelNotBefore
            // 
            this.labelNotBefore.AutoSize = true;
            this.labelNotBefore.Location = new System.Drawing.Point(180, 119);
            this.labelNotBefore.Name = "labelNotBefore";
            this.labelNotBefore.Size = new System.Drawing.Size(61, 13);
            this.labelNotBefore.TabIndex = 12;
            this.labelNotBefore.Text = "Not Before:";
            // 
            // labelNotBeforeData
            // 
            this.labelNotBeforeData.AutoSize = true;
            this.labelNotBeforeData.Location = new System.Drawing.Point(180, 142);
            this.labelNotBeforeData.Name = "labelNotBeforeData";
            this.labelNotBeforeData.Size = new System.Drawing.Size(13, 13);
            this.labelNotBeforeData.TabIndex = 13;
            this.labelNotBeforeData.Text = "_";
            // 
            // labelExpiresOn
            // 
            this.labelExpiresOn.AutoSize = true;
            this.labelExpiresOn.Location = new System.Drawing.Point(180, 174);
            this.labelExpiresOn.Name = "labelExpiresOn";
            this.labelExpiresOn.Size = new System.Drawing.Size(61, 13);
            this.labelExpiresOn.TabIndex = 14;
            this.labelExpiresOn.Text = "Expires On:";
            this.labelExpiresOn.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelExpiresOnData
            // 
            this.labelExpiresOnData.AutoSize = true;
            this.labelExpiresOnData.Location = new System.Drawing.Point(180, 194);
            this.labelExpiresOnData.Name = "labelExpiresOnData";
            this.labelExpiresOnData.Size = new System.Drawing.Size(13, 13);
            this.labelExpiresOnData.TabIndex = 15;
            this.labelExpiresOnData.Text = "_";
            // 
            // labelAccessToken
            // 
            this.labelAccessToken.AutoSize = true;
            this.labelAccessToken.Location = new System.Drawing.Point(180, 221);
            this.labelAccessToken.Name = "labelAccessToken";
            this.labelAccessToken.Size = new System.Drawing.Size(79, 13);
            this.labelAccessToken.TabIndex = 16;
            this.labelAccessToken.Text = "Access Token:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.labelAccessToken);
            this.Controls.Add(this.labelExpiresOnData);
            this.Controls.Add(this.labelExpiresOn);
            this.Controls.Add(this.labelNotBeforeData);
            this.Controls.Add(this.labelNotBefore);
            this.Controls.Add(this.labelExpiresInData);
            this.Controls.Add(this.labelExpiresIn);
            this.Controls.Add(this.labelTokenTypeData);
            this.Controls.Add(this.labelTokenType);
            this.Controls.Add(this.labelClientSecret);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.labelTenantId);
            this.Controls.Add(this.labelAccessTokenData);
            this.Controls.Add(this.buttonGetCredential);
            this.Controls.Add(this.textBoxClientSecret);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.textBoxTenantId);
            this.Name = "MainForm";
            this.Text = "Get Azure AD App Token";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTenantId;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxClientSecret;
        private System.Windows.Forms.Button buttonGetCredential;
        private System.Windows.Forms.Label labelAccessTokenData;
        private System.Windows.Forms.Label labelTenantId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClientSecret;
        private System.Windows.Forms.Label labelTokenType;
        private System.Windows.Forms.Label labelTokenTypeData;
        private System.Windows.Forms.Label labelExpiresIn;
        private System.Windows.Forms.Label labelExpiresInData;
        private System.Windows.Forms.Label labelNotBefore;
        private System.Windows.Forms.Label labelNotBeforeData;
        private System.Windows.Forms.Label labelExpiresOn;
        private System.Windows.Forms.Label labelExpiresOnData;
        private System.Windows.Forms.Label labelAccessToken;
    }
}

