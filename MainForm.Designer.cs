﻿namespace Maneubo
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
      if(disposing && (components != null))
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
      System.Windows.Forms.MenuStrip menuStrip;
      System.Windows.Forms.ToolStripMenuItem menuFile;
      System.Windows.Forms.ToolStripMenuItem miNew;
      System.Windows.Forms.ToolStripMenuItem miOpen;
      System.Windows.Forms.ToolStripMenuItem miSave;
      System.Windows.Forms.ToolStripMenuItem miSaveAs;
      System.Windows.Forms.ToolStripSeparator miSep1;
      System.Windows.Forms.ToolStripMenuItem miExit;
      System.Windows.Forms.ToolStripMenuItem menuEdit;
      System.Windows.Forms.ToolStripMenuItem miBackgroundImage;
      System.Windows.Forms.ToolStripSeparator menuSep2;
      System.Windows.Forms.ToolStripMenuItem menuTools;
      System.Windows.Forms.ToolStripMenuItem miQuickInterceptTool;
      System.Windows.Forms.ToolStripMenuItem miStopwatch;
      System.Windows.Forms.ToolStripMenuItem miProgramOptions;
      System.Windows.Forms.ToolStripMenuItem menuHelp;
      System.Windows.Forms.ToolStripMenuItem miAbout;
      System.Windows.Forms.StatusStrip statusStrip;
      System.Windows.Forms.ToolStripMenuItem miAirContact;
      System.Windows.Forms.ToolStripMenuItem miBoatShape;
      System.Windows.Forms.ToolStripMenuItem miHelicopterContact;
      System.Windows.Forms.ToolStripMenuItem miLandContact;
      System.Windows.Forms.ToolStripMenuItem miOwnShip;
      System.Windows.Forms.ToolStripMenuItem miSubsurfaceContact;
      System.Windows.Forms.ToolStripMenuItem miSurfaceContact;
      System.Windows.Forms.ToolStripMenuItem miUnknownContact;
      System.Windows.Forms.ToolStripMenuItem miWeaponContact;
      System.Windows.Forms.ToolStripMenuItem miPointObs;
      System.Windows.Forms.ToolStripMenuItem miBearingObs;
      System.Windows.Forms.ToolStripMenuItem miWaypoint;
      System.Windows.Forms.ToolStripSeparator tbSep2;
      System.Windows.Forms.ToolStripSeparator tbSep1;
      System.Windows.Forms.ToolStripMenuItem miAdvanceTime;
      System.Windows.Forms.ToolStripSeparator menuSep3;
      this.miRemoveBackground = new System.Windows.Forms.ToolStripMenuItem();
      this.miBoardOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblToolStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tbUnitShape = new System.Windows.Forms.ToolStripDropDownButton();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.tbPointer = new System.Windows.Forms.ToolStripButton();
      this.tbAddUnit = new System.Windows.Forms.ToolStripButton();
      this.tbAddObservation = new System.Windows.Forms.ToolStripButton();
      this.tbWaypointType = new System.Windows.Forms.ToolStripDropDownButton();
      this.tbLine = new System.Windows.Forms.ToolStripButton();
      this.tbCircle = new System.Windows.Forms.ToolStripButton();
      this.tbIntercept = new System.Windows.Forms.ToolStripButton();
      this.tbTMA = new System.Windows.Forms.ToolStripButton();
      this.tbSetBackground = new System.Windows.Forms.ToolStripButton();
      this.tbSetProjection = new System.Windows.Forms.ToolStripButton();
      this.board = new Maneubo.ManeuveringBoard();
      menuStrip = new System.Windows.Forms.MenuStrip();
      menuFile = new System.Windows.Forms.ToolStripMenuItem();
      miNew = new System.Windows.Forms.ToolStripMenuItem();
      miOpen = new System.Windows.Forms.ToolStripMenuItem();
      miSave = new System.Windows.Forms.ToolStripMenuItem();
      miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      miSep1 = new System.Windows.Forms.ToolStripSeparator();
      miExit = new System.Windows.Forms.ToolStripMenuItem();
      menuEdit = new System.Windows.Forms.ToolStripMenuItem();
      miBackgroundImage = new System.Windows.Forms.ToolStripMenuItem();
      menuSep2 = new System.Windows.Forms.ToolStripSeparator();
      menuTools = new System.Windows.Forms.ToolStripMenuItem();
      miQuickInterceptTool = new System.Windows.Forms.ToolStripMenuItem();
      miStopwatch = new System.Windows.Forms.ToolStripMenuItem();
      miProgramOptions = new System.Windows.Forms.ToolStripMenuItem();
      menuHelp = new System.Windows.Forms.ToolStripMenuItem();
      miAbout = new System.Windows.Forms.ToolStripMenuItem();
      statusStrip = new System.Windows.Forms.StatusStrip();
      miAirContact = new System.Windows.Forms.ToolStripMenuItem();
      miBoatShape = new System.Windows.Forms.ToolStripMenuItem();
      miHelicopterContact = new System.Windows.Forms.ToolStripMenuItem();
      miLandContact = new System.Windows.Forms.ToolStripMenuItem();
      miOwnShip = new System.Windows.Forms.ToolStripMenuItem();
      miSubsurfaceContact = new System.Windows.Forms.ToolStripMenuItem();
      miSurfaceContact = new System.Windows.Forms.ToolStripMenuItem();
      miUnknownContact = new System.Windows.Forms.ToolStripMenuItem();
      miWeaponContact = new System.Windows.Forms.ToolStripMenuItem();
      miPointObs = new System.Windows.Forms.ToolStripMenuItem();
      miBearingObs = new System.Windows.Forms.ToolStripMenuItem();
      miWaypoint = new System.Windows.Forms.ToolStripMenuItem();
      tbSep2 = new System.Windows.Forms.ToolStripSeparator();
      tbSep1 = new System.Windows.Forms.ToolStripSeparator();
      miAdvanceTime = new System.Windows.Forms.ToolStripMenuItem();
      menuSep3 = new System.Windows.Forms.ToolStripSeparator();
      menuStrip.SuspendLayout();
      statusStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuFile,
            menuEdit,
            menuTools,
            menuHelp});
      menuStrip.Location = new System.Drawing.Point(0, 0);
      menuStrip.Name = "menuStrip";
      menuStrip.Size = new System.Drawing.Size(792, 24);
      menuStrip.TabIndex = 0;
      // 
      // menuFile
      // 
      menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miNew,
            miOpen,
            miSave,
            miSaveAs,
            miSep1,
            miExit});
      menuFile.Name = "menuFile";
      menuFile.Size = new System.Drawing.Size(37, 20);
      menuFile.Text = "&File";
      // 
      // miNew
      // 
      miNew.Name = "miNew";
      miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      miNew.Size = new System.Drawing.Size(195, 22);
      miNew.Text = "&New";
      miNew.Click += new System.EventHandler(this.miNew_Click);
      // 
      // miOpen
      // 
      miOpen.Name = "miOpen";
      miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      miOpen.Size = new System.Drawing.Size(195, 22);
      miOpen.Text = "&Open...";
      miOpen.Click += new System.EventHandler(this.miOpen_Click);
      // 
      // miSave
      // 
      miSave.Name = "miSave";
      miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      miSave.Size = new System.Drawing.Size(195, 22);
      miSave.Text = "&Save";
      miSave.Click += new System.EventHandler(this.miSave_Click);
      // 
      // miSaveAs
      // 
      miSaveAs.Name = "miSaveAs";
      miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
      miSaveAs.Size = new System.Drawing.Size(195, 22);
      miSaveAs.Text = "Save &As...";
      miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
      // 
      // miSep1
      // 
      miSep1.Name = "miSep1";
      miSep1.Size = new System.Drawing.Size(192, 6);
      // 
      // miExit
      // 
      miExit.Name = "miExit";
      miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      miExit.Size = new System.Drawing.Size(195, 22);
      miExit.Text = "E&xit";
      miExit.Click += new System.EventHandler(this.miExit_Click);
      // 
      // menuEdit
      // 
      menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miBackgroundImage,
            this.miRemoveBackground,
            menuSep2,
            this.miBoardOptions});
      menuEdit.Name = "menuEdit";
      menuEdit.Size = new System.Drawing.Size(39, 20);
      menuEdit.Text = "&Edit";
      // 
      // miBackgroundImage
      // 
      miBackgroundImage.Name = "miBackgroundImage";
      miBackgroundImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      miBackgroundImage.Size = new System.Drawing.Size(293, 22);
      miBackgroundImage.Text = "Set &Background Image...";
      miBackgroundImage.Click += new System.EventHandler(this.miBackgroundImage_Click);
      // 
      // miRemoveBackground
      // 
      this.miRemoveBackground.Enabled = false;
      this.miRemoveBackground.Name = "miRemoveBackground";
      this.miRemoveBackground.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
      this.miRemoveBackground.Size = new System.Drawing.Size(293, 22);
      this.miRemoveBackground.Text = "&Remove Background Image";
      this.miRemoveBackground.Click += new System.EventHandler(this.miRemoveBackground_Click);
      // 
      // menuSep2
      // 
      menuSep2.Name = "menuSep2";
      menuSep2.Size = new System.Drawing.Size(290, 6);
      // 
      // miBoardOptions
      // 
      this.miBoardOptions.Name = "miBoardOptions";
      this.miBoardOptions.Size = new System.Drawing.Size(293, 22);
      this.miBoardOptions.Text = "Board &Options...";
      this.miBoardOptions.Click += new System.EventHandler(this.miBoardOptions_Click);
      // 
      // menuTools
      // 
      menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miAdvanceTime,
            miQuickInterceptTool,
            miStopwatch,
            menuSep3,
            miProgramOptions});
      menuTools.Name = "menuTools";
      menuTools.Size = new System.Drawing.Size(48, 20);
      menuTools.Text = "&Tools";
      // 
      // miQuickInterceptTool
      // 
      miQuickInterceptTool.Name = "miQuickInterceptTool";
      miQuickInterceptTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
      miQuickInterceptTool.Size = new System.Drawing.Size(228, 22);
      miQuickInterceptTool.Text = "Quick &Intercept Tool...";
      miQuickInterceptTool.Click += new System.EventHandler(this.miQuickInterceptTool_Click);
      // 
      // miStopwatch
      // 
      miStopwatch.Name = "miStopwatch";
      miStopwatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      miStopwatch.Size = new System.Drawing.Size(228, 22);
      miStopwatch.Text = "&Stopwatch...";
      miStopwatch.Click += new System.EventHandler(this.miStopwatch_Click);
      // 
      // miProgramOptions
      // 
      miProgramOptions.Name = "miProgramOptions";
      miProgramOptions.Size = new System.Drawing.Size(228, 22);
      miProgramOptions.Text = "Program &Options...";
      miProgramOptions.Click += new System.EventHandler(this.miProgramOptions_Click);
      // 
      // menuHelp
      // 
      menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miAbout});
      menuHelp.Name = "menuHelp";
      menuHelp.Size = new System.Drawing.Size(44, 20);
      menuHelp.Text = "&Help";
      // 
      // miAbout
      // 
      miAbout.Name = "miAbout";
      miAbout.Size = new System.Drawing.Size(152, 22);
      miAbout.Text = "&About...";
      miAbout.Click += new System.EventHandler(this.miAbout_Click);
      // 
      // statusStrip
      // 
      statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblToolStatus});
      statusStrip.Location = new System.Drawing.Point(0, 717);
      statusStrip.Name = "statusStrip";
      statusStrip.Size = new System.Drawing.Size(792, 22);
      statusStrip.TabIndex = 3;
      // 
      // lblStatus
      // 
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(777, 17);
      this.lblStatus.Spring = true;
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblToolStatus
      // 
      this.lblToolStatus.Name = "lblToolStatus";
      this.lblToolStatus.Size = new System.Drawing.Size(0, 17);
      this.lblToolStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // miAirContact
      // 
      miAirContact.Image = global::Maneubo.Properties.Resources.IconAir;
      miAirContact.Name = "miAirContact";
      miAirContact.Size = new System.Drawing.Size(132, 22);
      miAirContact.Tag = Maneubo.UnitShapeType.Air;
      miAirContact.Text = "&Air";
      miAirContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miBoatShape
      // 
      miBoatShape.Image = global::Maneubo.Properties.Resources.IconBoat;
      miBoatShape.Name = "miBoatShape";
      miBoatShape.Size = new System.Drawing.Size(132, 22);
      miBoatShape.Tag = Maneubo.UnitShapeType.Boat;
      miBoatShape.Text = "&Boat";
      miBoatShape.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miHelicopterContact
      // 
      miHelicopterContact.Image = global::Maneubo.Properties.Resources.IconHelo;
      miHelicopterContact.Name = "miHelicopterContact";
      miHelicopterContact.Size = new System.Drawing.Size(132, 22);
      miHelicopterContact.Tag = Maneubo.UnitShapeType.Helicopter;
      miHelicopterContact.Text = "&Helicopter";
      miHelicopterContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miLandContact
      // 
      miLandContact.Image = global::Maneubo.Properties.Resources.IconLand;
      miLandContact.Name = "miLandContact";
      miLandContact.Size = new System.Drawing.Size(132, 22);
      miLandContact.Tag = Maneubo.UnitShapeType.Land;
      miLandContact.Text = "&Land";
      miLandContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miOwnShip
      // 
      miOwnShip.Image = global::Maneubo.Properties.Resources.IconOwnShip;
      miOwnShip.Name = "miOwnShip";
      miOwnShip.Size = new System.Drawing.Size(132, 22);
      miOwnShip.Tag = Maneubo.UnitShapeType.OwnShip;
      miOwnShip.Text = "&Own Ship";
      miOwnShip.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miSubsurfaceContact
      // 
      miSubsurfaceContact.Image = global::Maneubo.Properties.Resources.IconSubsurface;
      miSubsurfaceContact.Name = "miSubsurfaceContact";
      miSubsurfaceContact.Size = new System.Drawing.Size(132, 22);
      miSubsurfaceContact.Tag = Maneubo.UnitShapeType.Subsurface;
      miSubsurfaceContact.Text = "&Subsurface";
      miSubsurfaceContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miSurfaceContact
      // 
      miSurfaceContact.Checked = true;
      miSurfaceContact.CheckState = System.Windows.Forms.CheckState.Checked;
      miSurfaceContact.Image = global::Maneubo.Properties.Resources.IconSurface;
      miSurfaceContact.Name = "miSurfaceContact";
      miSurfaceContact.Size = new System.Drawing.Size(132, 22);
      miSurfaceContact.Tag = Maneubo.UnitShapeType.Surface;
      miSurfaceContact.Text = "Su&rface";
      miSurfaceContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miUnknownContact
      // 
      miUnknownContact.Image = global::Maneubo.Properties.Resources.IconUnknown;
      miUnknownContact.Name = "miUnknownContact";
      miUnknownContact.Size = new System.Drawing.Size(132, 22);
      miUnknownContact.Tag = Maneubo.UnitShapeType.Unknown;
      miUnknownContact.Text = "&Unknown";
      miUnknownContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miWeaponContact
      // 
      miWeaponContact.Image = global::Maneubo.Properties.Resources.IconWeapon;
      miWeaponContact.Name = "miWeaponContact";
      miWeaponContact.Size = new System.Drawing.Size(132, 22);
      miWeaponContact.Tag = Maneubo.UnitShapeType.Weapon;
      miWeaponContact.Text = "&Weapon";
      miWeaponContact.Click += new System.EventHandler(this.miContactShape_Click);
      // 
      // miPointObs
      // 
      miPointObs.Checked = true;
      miPointObs.CheckState = System.Windows.Forms.CheckState.Checked;
      miPointObs.Image = global::Maneubo.Properties.Resources.IconObsPoint;
      miPointObs.Name = "miPointObs";
      miPointObs.Size = new System.Drawing.Size(181, 22);
      miPointObs.Tag = Maneubo.PositionalDataType.Point;
      miPointObs.Text = "&Point Observation";
      miPointObs.Click += new System.EventHandler(this.miObsType_Click);
      // 
      // miBearingObs
      // 
      miBearingObs.Image = global::Maneubo.Properties.Resources.IconObsBearing;
      miBearingObs.Name = "miBearingObs";
      miBearingObs.Size = new System.Drawing.Size(181, 22);
      miBearingObs.Tag = Maneubo.PositionalDataType.BearingLine;
      miBearingObs.Text = "&Bearing Observation";
      miBearingObs.Click += new System.EventHandler(this.miObsType_Click);
      // 
      // miWaypoint
      // 
      miWaypoint.Image = global::Maneubo.Properties.Resources.IconWaypoint;
      miWaypoint.Name = "miWaypoint";
      miWaypoint.Size = new System.Drawing.Size(181, 22);
      miWaypoint.Tag = Maneubo.PositionalDataType.Waypoint;
      miWaypoint.Text = "&Waypoint";
      miWaypoint.Click += new System.EventHandler(this.miObsType_Click);
      // 
      // tbSep2
      // 
      tbSep2.Name = "tbSep2";
      tbSep2.Size = new System.Drawing.Size(6, 25);
      // 
      // tbSep1
      // 
      tbSep1.Name = "tbSep1";
      tbSep1.Size = new System.Drawing.Size(6, 25);
      // 
      // tbUnitShape
      // 
      this.tbUnitShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
      this.tbUnitShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miAirContact,
            miBoatShape,
            miHelicopterContact,
            miLandContact,
            miOwnShip,
            miSubsurfaceContact,
            miSurfaceContact,
            miUnknownContact,
            miWeaponContact});
      this.tbUnitShape.Name = "tbUnitShape";
      this.tbUnitShape.Size = new System.Drawing.Size(13, 22);
      this.tbUnitShape.Text = "Select Unit Shape (F3)";
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbPointer,
            this.tbAddUnit,
            this.tbUnitShape,
            this.tbAddObservation,
            this.tbWaypointType,
            this.tbLine,
            this.tbCircle,
            tbSep1,
            this.tbIntercept,
            this.tbTMA,
            tbSep2,
            this.tbSetBackground,
            this.tbSetProjection});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(792, 25);
      this.toolStrip.TabIndex = 2;
      // 
      // tbPointer
      // 
      this.tbPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbPointer.Image = global::Maneubo.Properties.Resources.IconPointer;
      this.tbPointer.Name = "tbPointer";
      this.tbPointer.Size = new System.Drawing.Size(23, 22);
      this.tbPointer.Text = "Pointer (P)";
      this.tbPointer.Click += new System.EventHandler(this.tbPointer_Click);
      // 
      // tbAddUnit
      // 
      this.tbAddUnit.Checked = true;
      this.tbAddUnit.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tbAddUnit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbAddUnit.Image = global::Maneubo.Properties.Resources.IconSurface;
      this.tbAddUnit.Name = "tbAddUnit";
      this.tbAddUnit.Size = new System.Drawing.Size(23, 22);
      this.tbAddUnit.Text = "Add Unit (U)";
      this.tbAddUnit.Click += new System.EventHandler(this.tbAddUnit_Click);
      // 
      // tbAddObservation
      // 
      this.tbAddObservation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbAddObservation.Enabled = false;
      this.tbAddObservation.Image = global::Maneubo.Properties.Resources.IconObsPoint;
      this.tbAddObservation.Name = "tbAddObservation";
      this.tbAddObservation.Size = new System.Drawing.Size(23, 22);
      this.tbAddObservation.Text = "Add Observation/Waypoint (O)";
      this.tbAddObservation.Click += new System.EventHandler(this.tbAddObservation_Click);
      // 
      // tbWaypointType
      // 
      this.tbWaypointType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbWaypointType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            miPointObs,
            miBearingObs,
            miWaypoint});
      this.tbWaypointType.Name = "tbWaypointType";
      this.tbWaypointType.Size = new System.Drawing.Size(13, 22);
      this.tbWaypointType.Text = "Select Observation/Waypoint Type (F4)";
      // 
      // tbLine
      // 
      this.tbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbLine.Image = global::Maneubo.Properties.Resources.IconLine;
      this.tbLine.Name = "tbLine";
      this.tbLine.Size = new System.Drawing.Size(23, 22);
      this.tbLine.Text = "Add Line (L)";
      this.tbLine.Click += new System.EventHandler(this.tbLine_Click);
      // 
      // tbCircle
      // 
      this.tbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbCircle.Image = global::Maneubo.Properties.Resources.IconCircle;
      this.tbCircle.Name = "tbCircle";
      this.tbCircle.Size = new System.Drawing.Size(23, 22);
      this.tbCircle.Text = "Add Circle (C)";
      this.tbCircle.Click += new System.EventHandler(this.tbCircle_Click);
      // 
      // tbIntercept
      // 
      this.tbIntercept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbIntercept.Image = global::Maneubo.Properties.Resources.IconIntercept;
      this.tbIntercept.Name = "tbIntercept";
      this.tbIntercept.Size = new System.Drawing.Size(23, 22);
      this.tbIntercept.Text = "Calculate Intercept (I)";
      this.tbIntercept.Click += new System.EventHandler(this.tbIntercept_Click);
      // 
      // tbTMA
      // 
      this.tbTMA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbTMA.Image = global::Maneubo.Properties.Resources.IconTMA;
      this.tbTMA.Name = "tbTMA";
      this.tbTMA.Size = new System.Drawing.Size(23, 22);
      this.tbTMA.Text = "Target Motion Analysis (T)";
      this.tbTMA.Click += new System.EventHandler(this.tbTMA_Click);
      // 
      // tbSetBackground
      // 
      this.tbSetBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbSetBackground.Image = global::Maneubo.Properties.Resources.IconBackground;
      this.tbSetBackground.Name = "tbSetBackground";
      this.tbSetBackground.Size = new System.Drawing.Size(23, 22);
      this.tbSetBackground.Text = "Setup Background Image";
      this.tbSetBackground.Click += new System.EventHandler(this.tbSetBackground_Click);
      // 
      // tbSetProjection
      // 
      this.tbSetProjection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbSetProjection.Image = global::Maneubo.Properties.Resources.IconMap;
      this.tbSetProjection.Name = "tbSetProjection";
      this.tbSetProjection.Size = new System.Drawing.Size(23, 22);
      this.tbSetProjection.Text = "Setup Map Projection";
      this.tbSetProjection.Click += new System.EventHandler(this.tbSetProjection_Click);
      // 
      // board
      // 
      this.board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
      this.board.Cursor = System.Windows.Forms.Cursors.Default;
      this.board.Dock = System.Windows.Forms.DockStyle.Fill;
      this.board.Location = new System.Drawing.Point(0, 49);
      this.board.Name = "board";
      this.board.Size = new System.Drawing.Size(792, 668);
      this.board.TabIndex = 0;
      this.board.ReferenceShapeChanged += new System.EventHandler(this.board_ReferenceShapeChanged);
      this.board.StatusTextChanged += new System.EventHandler(this.board_StatusTextChanged);
      this.board.ToolChanged += new System.EventHandler(this.board_ToolChanged);
      this.board.BackgroundImageChanged += new System.EventHandler(this.board_BackgroundImageChanged);
      // 
      // miAdvanceTime
      // 
      miAdvanceTime.Name = "miAdvanceTime";
      miAdvanceTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      miAdvanceTime.Size = new System.Drawing.Size(228, 22);
      miAdvanceTime.Text = "Advance &Time...";
      miAdvanceTime.Click += new System.EventHandler(this.miAdvanceTime_Click);
      // 
      // menuSep3
      // 
      menuSep3.Name = "menuSep3";
      menuSep3.Size = new System.Drawing.Size(225, 6);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 739);
      this.Controls.Add(this.board);
      this.Controls.Add(statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(menuStrip);
      this.KeyPreview = true;
      this.MainMenuStrip = menuStrip;
      this.Name = "MainForm";
      this.Text = "Maneubo - Virtual Maneuvering Board";
      menuStrip.ResumeLayout(false);
      menuStrip.PerformLayout();
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    private System.Windows.Forms.ToolStripStatusLabel lblToolStatus;
    private ManeuveringBoard board;
    private System.Windows.Forms.ToolStripButton tbPointer;
    private System.Windows.Forms.ToolStripButton tbAddUnit;
    private System.Windows.Forms.ToolStripButton tbLine;
    private System.Windows.Forms.ToolStripButton tbCircle;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripDropDownButton tbUnitShape;
    private System.Windows.Forms.ToolStripButton tbAddObservation;
    private System.Windows.Forms.ToolStripDropDownButton tbWaypointType;
    private System.Windows.Forms.ToolStripButton tbSetBackground;
    private System.Windows.Forms.ToolStripMenuItem miRemoveBackground;
    private System.Windows.Forms.ToolStripButton tbTMA;
    private System.Windows.Forms.ToolStripMenuItem miBoardOptions;
    private System.Windows.Forms.ToolStripButton tbSetProjection;
    private System.Windows.Forms.ToolStripButton tbIntercept;
  }
}

