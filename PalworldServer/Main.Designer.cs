namespace PalworldServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.DragControl = new Bunifu.UI.WinForms.BunifuFormDrag();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.brnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblFolderLoc = new System.Windows.Forms.Label();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbLogs = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnInstall = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbFolder = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.AllowOpacityChangesWhileDragging = false;
            this.DragControl.ContainerControl = this;
            this.DragControl.DockIndicatorsOpacity = 0.5D;
            this.DragControl.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.DragControl.DockingOptions.DockAll = false;
            this.DragControl.DockingOptions.DockBottomLeft = false;
            this.DragControl.DockingOptions.DockBottomRight = false;
            this.DragControl.DockingOptions.DockFullScreen = false;
            this.DragControl.DockingOptions.DockLeft = false;
            this.DragControl.DockingOptions.DockRight = false;
            this.DragControl.DockingOptions.DockTopLeft = false;
            this.DragControl.DockingOptions.DockTopRight = false;
            this.DragControl.DragOpacity = 0.9D;
            this.DragControl.Enabled = true;
            this.DragControl.ParentForm = this;
            this.DragControl.ShowCursorChanges = true;
            this.DragControl.ShowDockingIndicators = true;
            this.DragControl.TitleBarOptions.BunifuFormDrag = this.DragControl;
            this.DragControl.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.DragControl.TitleBarOptions.Enabled = true;
            this.DragControl.TitleBarOptions.TitleBarControl = this.pnlHeader;
            this.DragControl.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.Black;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BorderThickness = 2;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.brnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(800, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 29);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Palworld Server Creator v1.0.0";
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowBuffering = false;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.AllowZooming = true;
            this.btnMinimize.AllowZoomingOnFocus = false;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = global::PalworldServer.Properties.Resources.minimize;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 5;
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(709, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 5;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // brnClose
            // 
            this.brnClose.ActiveImage = null;
            this.brnClose.AllowAnimations = true;
            this.brnClose.AllowBuffering = false;
            this.brnClose.AllowToggling = false;
            this.brnClose.AllowZooming = true;
            this.brnClose.AllowZoomingOnFocus = false;
            this.brnClose.BackColor = System.Drawing.Color.Transparent;
            this.brnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.brnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brnClose.ErrorImage")));
            this.brnClose.FadeWhenInactive = false;
            this.brnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.brnClose.Image = global::PalworldServer.Properties.Resources.close;
            this.brnClose.ImageActive = null;
            this.brnClose.ImageLocation = null;
            this.brnClose.ImageMargin = 5;
            this.brnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.brnClose.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.brnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("brnClose.InitialImage")));
            this.brnClose.Location = new System.Drawing.Point(755, 5);
            this.brnClose.Name = "brnClose";
            this.brnClose.Rotation = 0;
            this.brnClose.ShowActiveImage = true;
            this.brnClose.ShowCursorChanges = true;
            this.brnClose.ShowImageBorders = true;
            this.brnClose.ShowSizeMarkers = false;
            this.brnClose.Size = new System.Drawing.Size(40, 40);
            this.brnClose.TabIndex = 0;
            this.brnClose.ToolTipText = "";
            this.brnClose.WaitOnLoad = false;
            this.brnClose.Zoom = 5;
            this.brnClose.ZoomSpeed = 10;
            this.brnClose.Click += new System.EventHandler(this.brnClose_Click);
            // 
            // lblFolderLoc
            // 
            this.lblFolderLoc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderLoc.Location = new System.Drawing.Point(12, 63);
            this.lblFolderLoc.Name = "lblFolderLoc";
            this.lblFolderLoc.Size = new System.Drawing.Size(400, 23);
            this.lblFolderLoc.TabIndex = 3;
            this.lblFolderLoc.Text = "Server Root Folder Location:";
            // 
            // lblStatus
            // 
            this.lblStatus.AllowParentOverrides = false;
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(16, 226);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(271, 29);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Server Status: Not Installed";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbLogs
            // 
            this.tbLogs.AcceptsReturn = false;
            this.tbLogs.AcceptsTab = false;
            this.tbLogs.AnimationSpeed = 200;
            this.tbLogs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbLogs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbLogs.AutoSizeHeight = true;
            this.tbLogs.BackColor = System.Drawing.Color.Transparent;
            this.tbLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbLogs.BackgroundImage")));
            this.tbLogs.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbLogs.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbLogs.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbLogs.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbLogs.BorderRadius = 1;
            this.tbLogs.BorderThickness = 1;
            this.tbLogs.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.tbLogs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogs.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbLogs.DefaultText = "";
            this.tbLogs.FillColor = System.Drawing.Color.White;
            this.tbLogs.ForeColor = System.Drawing.Color.DimGray;
            this.tbLogs.HideSelection = true;
            this.tbLogs.IconLeft = null;
            this.tbLogs.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogs.IconPadding = 10;
            this.tbLogs.IconRight = null;
            this.tbLogs.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogs.Lines = new string[0];
            this.tbLogs.Location = new System.Drawing.Point(12, 273);
            this.tbLogs.MaxLength = 32767;
            this.tbLogs.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbLogs.Modified = false;
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbLogs.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbLogs.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbLogs.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.DimGray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbLogs.OnIdleState = stateProperties4;
            this.tbLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogs.PasswordChar = '\0';
            this.tbLogs.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbLogs.PlaceholderText = "";
            this.tbLogs.ReadOnly = true;
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogs.SelectedText = "";
            this.tbLogs.SelectionLength = 0;
            this.tbLogs.SelectionStart = 0;
            this.tbLogs.ShortcutsEnabled = true;
            this.tbLogs.Size = new System.Drawing.Size(776, 165);
            this.tbLogs.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbLogs.TabIndex = 5;
            this.tbLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLogs.TextMarginBottom = 0;
            this.tbLogs.TextMarginLeft = 3;
            this.tbLogs.TextMarginTop = 1;
            this.tbLogs.TextPlaceholder = "";
            this.tbLogs.UseSystemPasswordChar = false;
            this.tbLogs.WordWrap = true;
            // 
            // btnInstall
            // 
            this.btnInstall.AllowAnimations = true;
            this.btnInstall.AllowMouseEffects = true;
            this.btnInstall.AllowToggling = false;
            this.btnInstall.AnimationSpeed = 200;
            this.btnInstall.AutoGenerateColors = false;
            this.btnInstall.AutoRoundBorders = false;
            this.btnInstall.AutoSizeLeftIcon = true;
            this.btnInstall.AutoSizeRightIcon = true;
            this.btnInstall.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnInstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstall.BackgroundImage")));
            this.btnInstall.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstall.ButtonText = "Install Server";
            this.btnInstall.ButtonTextMarginLeft = 0;
            this.btnInstall.ColorContrastOnClick = 45;
            this.btnInstall.ColorContrastOnHover = 45;
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnInstall.CustomizableEdges = borderEdges1;
            this.btnInstall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInstall.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInstall.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnInstall.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnInstall.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInstall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.IconLeft = null;
            this.btnInstall.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstall.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInstall.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInstall.IconMarginLeft = 11;
            this.btnInstall.IconPadding = 10;
            this.btnInstall.IconRight = null;
            this.btnInstall.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstall.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInstall.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInstall.IconSize = 25;
            this.btnInstall.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnInstall.IdleBorderRadius = 0;
            this.btnInstall.IdleBorderThickness = 0;
            this.btnInstall.IdleFillColor = System.Drawing.Color.Empty;
            this.btnInstall.IdleIconLeftImage = null;
            this.btnInstall.IdleIconRightImage = null;
            this.btnInstall.IndicateFocus = false;
            this.btnInstall.Location = new System.Drawing.Point(538, 156);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInstall.OnDisabledState.BorderRadius = 46;
            this.btnInstall.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstall.OnDisabledState.BorderThickness = 1;
            this.btnInstall.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInstall.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInstall.OnDisabledState.IconLeftImage = null;
            this.btnInstall.OnDisabledState.IconRightImage = null;
            this.btnInstall.onHoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnInstall.onHoverState.BorderRadius = 46;
            this.btnInstall.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstall.onHoverState.BorderThickness = 1;
            this.btnInstall.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnInstall.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInstall.onHoverState.IconLeftImage = null;
            this.btnInstall.onHoverState.IconRightImage = null;
            this.btnInstall.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnInstall.OnIdleState.BorderRadius = 46;
            this.btnInstall.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstall.OnIdleState.BorderThickness = 1;
            this.btnInstall.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnInstall.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInstall.OnIdleState.IconLeftImage = null;
            this.btnInstall.OnIdleState.IconRightImage = null;
            this.btnInstall.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnInstall.OnPressedState.BorderRadius = 46;
            this.btnInstall.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstall.OnPressedState.BorderThickness = 1;
            this.btnInstall.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnInstall.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInstall.OnPressedState.IconLeftImage = null;
            this.btnInstall.OnPressedState.IconRightImage = null;
            this.btnInstall.Size = new System.Drawing.Size(250, 50);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInstall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInstall.TextMarginLeft = 0;
            this.btnInstall.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInstall.UseDefaultRadiusAndThickness = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnStart
            // 
            this.btnStart.AllowAnimations = true;
            this.btnStart.AllowMouseEffects = true;
            this.btnStart.AllowToggling = false;
            this.btnStart.AnimationSpeed = 200;
            this.btnStart.AutoGenerateColors = false;
            this.btnStart.AutoRoundBorders = false;
            this.btnStart.AutoSizeLeftIcon = true;
            this.btnStart.AutoSizeRightIcon = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.ButtonText = "Start Server";
            this.btnStart.ButtonTextMarginLeft = 0;
            this.btnStart.ColorContrastOnClick = 45;
            this.btnStart.ColorContrastOnHover = 45;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnStart.CustomizableEdges = borderEdges2;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnStart.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnStart.Enabled = false;
            this.btnStart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.IconLeft = null;
            this.btnStart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStart.IconMarginLeft = 11;
            this.btnStart.IconPadding = 10;
            this.btnStart.IconRight = null;
            this.btnStart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStart.IconSize = 25;
            this.btnStart.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnStart.IdleBorderRadius = 0;
            this.btnStart.IdleBorderThickness = 0;
            this.btnStart.IdleFillColor = System.Drawing.Color.Empty;
            this.btnStart.IdleIconLeftImage = null;
            this.btnStart.IdleIconRightImage = null;
            this.btnStart.IndicateFocus = false;
            this.btnStart.Location = new System.Drawing.Point(12, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.OnDisabledState.BorderRadius = 46;
            this.btnStart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnDisabledState.BorderThickness = 1;
            this.btnStart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStart.OnDisabledState.IconLeftImage = null;
            this.btnStart.OnDisabledState.IconRightImage = null;
            this.btnStart.onHoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnStart.onHoverState.BorderRadius = 46;
            this.btnStart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.onHoverState.BorderThickness = 1;
            this.btnStart.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnStart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStart.onHoverState.IconLeftImage = null;
            this.btnStart.onHoverState.IconRightImage = null;
            this.btnStart.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnStart.OnIdleState.BorderRadius = 46;
            this.btnStart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnIdleState.BorderThickness = 1;
            this.btnStart.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnStart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnIdleState.IconLeftImage = null;
            this.btnStart.OnIdleState.IconRightImage = null;
            this.btnStart.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnStart.OnPressedState.BorderRadius = 46;
            this.btnStart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnPressedState.BorderThickness = 1;
            this.btnStart.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnStart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnPressedState.IconLeftImage = null;
            this.btnStart.OnPressedState.IconRightImage = null;
            this.btnStart.Size = new System.Drawing.Size(250, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.TextMarginLeft = 0;
            this.btnStart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStart.UseDefaultRadiusAndThickness = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.AllowAnimations = true;
            this.btnSelect.AllowMouseEffects = true;
            this.btnSelect.AllowToggling = false;
            this.btnSelect.AnimationSpeed = 200;
            this.btnSelect.AutoGenerateColors = false;
            this.btnSelect.AutoRoundBorders = false;
            this.btnSelect.AutoSizeLeftIcon = true;
            this.btnSelect.AutoSizeRightIcon = true;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelect.ButtonText = "SELECT";
            this.btnSelect.ButtonTextMarginLeft = 0;
            this.btnSelect.ColorContrastOnClick = 45;
            this.btnSelect.ColorContrastOnHover = 45;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSelect.CustomizableEdges = borderEdges3;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelect.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSelect.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSelect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.IconLeft = null;
            this.btnSelect.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSelect.IconMarginLeft = 11;
            this.btnSelect.IconPadding = 10;
            this.btnSelect.IconRight = null;
            this.btnSelect.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSelect.IconSize = 25;
            this.btnSelect.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSelect.IdleBorderRadius = 0;
            this.btnSelect.IdleBorderThickness = 0;
            this.btnSelect.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSelect.IdleIconLeftImage = null;
            this.btnSelect.IdleIconRightImage = null;
            this.btnSelect.IndicateFocus = false;
            this.btnSelect.Location = new System.Drawing.Point(661, 90);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelect.OnDisabledState.BorderRadius = 46;
            this.btnSelect.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelect.OnDisabledState.BorderThickness = 1;
            this.btnSelect.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelect.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelect.OnDisabledState.IconLeftImage = null;
            this.btnSelect.OnDisabledState.IconRightImage = null;
            this.btnSelect.onHoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelect.onHoverState.BorderRadius = 46;
            this.btnSelect.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelect.onHoverState.BorderThickness = 1;
            this.btnSelect.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnSelect.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.onHoverState.IconLeftImage = null;
            this.btnSelect.onHoverState.IconRightImage = null;
            this.btnSelect.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnSelect.OnIdleState.BorderRadius = 46;
            this.btnSelect.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelect.OnIdleState.BorderThickness = 1;
            this.btnSelect.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnSelect.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.OnIdleState.IconLeftImage = null;
            this.btnSelect.OnIdleState.IconRightImage = null;
            this.btnSelect.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnSelect.OnPressedState.BorderRadius = 46;
            this.btnSelect.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelect.OnPressedState.BorderThickness = 1;
            this.btnSelect.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnSelect.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.OnPressedState.IconLeftImage = null;
            this.btnSelect.OnPressedState.IconRightImage = null;
            this.btnSelect.Size = new System.Drawing.Size(127, 46);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelect.TextMarginLeft = 0;
            this.btnSelect.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelect.UseDefaultRadiusAndThickness = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.AcceptsReturn = false;
            this.tbFolder.AcceptsTab = false;
            this.tbFolder.AnimationSpeed = 200;
            this.tbFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbFolder.AutoSizeHeight = true;
            this.tbFolder.BackColor = System.Drawing.Color.White;
            this.tbFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFolder.BackgroundImage")));
            this.tbFolder.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbFolder.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbFolder.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbFolder.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbFolder.BorderRadius = 1;
            this.tbFolder.BorderThickness = 1;
            this.tbFolder.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.tbFolder.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFolder.DefaultFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolder.DefaultText = "";
            this.tbFolder.FillColor = System.Drawing.Color.White;
            this.tbFolder.ForeColor = System.Drawing.Color.DimGray;
            this.tbFolder.HideSelection = true;
            this.tbFolder.IconLeft = null;
            this.tbFolder.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFolder.IconPadding = 10;
            this.tbFolder.IconRight = null;
            this.tbFolder.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFolder.Lines = new string[0];
            this.tbFolder.Location = new System.Drawing.Point(12, 90);
            this.tbFolder.MaxLength = 32767;
            this.tbFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbFolder.Modified = false;
            this.tbFolder.Multiline = false;
            this.tbFolder.Name = "tbFolder";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbFolder.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbFolder.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbFolder.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.DimGray;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbFolder.OnIdleState = stateProperties8;
            this.tbFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tbFolder.PasswordChar = '\0';
            this.tbFolder.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbFolder.PlaceholderText = "";
            this.tbFolder.ReadOnly = true;
            this.tbFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFolder.SelectedText = "";
            this.tbFolder.SelectionLength = 0;
            this.tbFolder.SelectionStart = 0;
            this.tbFolder.ShortcutsEnabled = true;
            this.tbFolder.Size = new System.Drawing.Size(638, 46);
            this.tbFolder.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.tbFolder.TabIndex = 1;
            this.tbFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFolder.TextMarginBottom = 0;
            this.tbFolder.TextMarginLeft = 3;
            this.tbFolder.TextMarginTop = 1;
            this.tbFolder.TextPlaceholder = "";
            this.tbFolder.UseSystemPasswordChar = false;
            this.tbFolder.WordWrap = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLogs);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFolderLoc);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palworld Server";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuImageButton brnClose;
        private System.Windows.Forms.Label lblHeader;
        private Bunifu.UI.WinForms.BunifuTextBox tbFolder;
        private Bunifu.UI.WinForms.BunifuFormDrag DragControl;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelect;
        private System.Windows.Forms.Label lblFolderLoc;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInstall;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStart;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private Bunifu.UI.WinForms.BunifuTextBox tbLogs;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
    }
}

