<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StructurePreviewSplitter = New System.Windows.Forms.Splitter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LegalValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MethodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDAReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudyOutlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertyGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataManagerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByVariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatabaseUpdaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbxLanguage = New System.Windows.Forms.ToolStripComboBox()
        Me.ExpresionEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenQMFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveHtmlDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveDictonaryDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PreviewPropertyGridSplitter = New System.Windows.Forms.Splitter()
        Me.uxPreviewControl = New UI.PreviewControl()
        Me.uxQuestions = New UI.CtlQuestions()
        Me.uxlInformation = New UI.CtlInformation()
        Me.uxCheckpoint = New UI.CtlCheckpoint()
        Me.uxVariable = New UI.CtlVariable()
        Me.uxStudy = New UI.CtlStudy()
        Me.uxQuestionnaireSet = New UI.CtlQuestionnaireSet()
        Me.uxQuestionnaire = New UI.CtlQuestionnaire()
        Me.StructureControl1 = New UI.StructureControl()
        Me.UxSection = New UI.CtlSection()
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StructurePreviewSplitter
        '
        Me.StructurePreviewSplitter.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.UI.My.MySettings.Default, "Main_structurePreviewSplitter_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StructurePreviewSplitter.Location = Global.UI.My.MySettings.Default.Main_structurePreviewSplitter_Location
        Me.StructurePreviewSplitter.Name = "StructurePreviewSplitter"
        Me.StructurePreviewSplitter.Size = New System.Drawing.Size(3, 655)
        Me.StructurePreviewSplitter.TabIndex = 7
        Me.StructurePreviewSplitter.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.cbxLanguage, Me.ExpresionEditorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.PrintPreviewToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.NewToolStripMenuItem.Text = "New Study"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.SaveToolStripMenuItem1.Text = "Save..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem3.Text = "Save Preview..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem1.Text = "Page Setup..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem2.Text = "Preview"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.ToolStripSeparator5, Me.LegalValuesToolStripMenuItem, Me.SitesToolStripMenuItem, Me.LanguagesToolStripMenuItem, Me.UsersToolStripMenuItem, Me.MethodsToolStripMenuItem, Me.FilesToolStripMenuItem, Me.PDAReportsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 23)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FindToolStripMenuItem.Text = "Find..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(143, 6)
        '
        'LegalValuesToolStripMenuItem
        '
        Me.LegalValuesToolStripMenuItem.Name = "LegalValuesToolStripMenuItem"
        Me.LegalValuesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LegalValuesToolStripMenuItem.Text = "Legal Values"
        '
        'SitesToolStripMenuItem
        '
        Me.SitesToolStripMenuItem.Name = "SitesToolStripMenuItem"
        Me.SitesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SitesToolStripMenuItem.Text = "Sites"
        '
        'LanguagesToolStripMenuItem
        '
        Me.LanguagesToolStripMenuItem.Name = "LanguagesToolStripMenuItem"
        Me.LanguagesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LanguagesToolStripMenuItem.Text = "Languages"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'MethodsToolStripMenuItem
        '
        Me.MethodsToolStripMenuItem.Name = "MethodsToolStripMenuItem"
        Me.MethodsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.MethodsToolStripMenuItem.Text = "Methods"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'PDAReportsToolStripMenuItem
        '
        Me.PDAReportsToolStripMenuItem.Name = "PDAReportsToolStripMenuItem"
        Me.PDAReportsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PDAReportsToolStripMenuItem.Text = "PDA Reports"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudyOutlineToolStripMenuItem, Me.PreviewPanelToolStripMenuItem, Me.PropertyGridToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'StudyOutlineToolStripMenuItem
        '
        Me.StudyOutlineToolStripMenuItem.Checked = True
        Me.StudyOutlineToolStripMenuItem.CheckOnClick = True
        Me.StudyOutlineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StudyOutlineToolStripMenuItem.Name = "StudyOutlineToolStripMenuItem"
        Me.StudyOutlineToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.StudyOutlineToolStripMenuItem.Text = "Study Outline"
        '
        'PreviewPanelToolStripMenuItem
        '
        Me.PreviewPanelToolStripMenuItem.Checked = True
        Me.PreviewPanelToolStripMenuItem.CheckOnClick = True
        Me.PreviewPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PreviewPanelToolStripMenuItem.Name = "PreviewPanelToolStripMenuItem"
        Me.PreviewPanelToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PreviewPanelToolStripMenuItem.Text = "Preview Panel"
        '
        'PropertyGridToolStripMenuItem
        '
        Me.PropertyGridToolStripMenuItem.Checked = True
        Me.PropertyGridToolStripMenuItem.CheckOnClick = True
        Me.PropertyGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PropertyGridToolStripMenuItem.Name = "PropertyGridToolStripMenuItem"
        Me.PropertyGridToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PropertyGridToolStripMenuItem.Text = "Property Grid"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataManagerToolStripMenuItem1, Me.DictionaryToolStripMenuItem, Me.ToolStripSeparator4, Me.DatabaseUpdaterToolStripMenuItem, Me.GenerateToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 23)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DataManagerToolStripMenuItem1
        '
        Me.DataManagerToolStripMenuItem1.Name = "DataManagerToolStripMenuItem1"
        Me.DataManagerToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.DataManagerToolStripMenuItem1.Text = "Data Manager"
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByVariableToolStripMenuItem, Me.ByQuestionToolStripMenuItem})
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DictionaryToolStripMenuItem.Text = "Data Dictionary"
        '
        'ByVariableToolStripMenuItem
        '
        Me.ByVariableToolStripMenuItem.Name = "ByVariableToolStripMenuItem"
        Me.ByVariableToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ByVariableToolStripMenuItem.Text = "By Variable"
        '
        'ByQuestionToolStripMenuItem
        '
        Me.ByQuestionToolStripMenuItem.Name = "ByQuestionToolStripMenuItem"
        Me.ByQuestionToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ByQuestionToolStripMenuItem.Text = "By Question"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(164, 6)
        '
        'DatabaseUpdaterToolStripMenuItem
        '
        Me.DatabaseUpdaterToolStripMenuItem.Name = "DatabaseUpdaterToolStripMenuItem"
        Me.DatabaseUpdaterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DatabaseUpdaterToolStripMenuItem.Text = "Database Updater"
        '
        'GenerateToolStripMenuItem
        '
        Me.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem"
        Me.GenerateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.GenerateToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GenerateToolStripMenuItem.Text = "Generate"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'cbxLanguage
        '
        Me.cbxLanguage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbxLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(121, 23)
        '
        'ExpresionEditorToolStripMenuItem
        '
        Me.ExpresionEditorToolStripMenuItem.Name = "ExpresionEditorToolStripMenuItem"
        Me.ExpresionEditorToolStripMenuItem.Size = New System.Drawing.Size(103, 23)
        Me.ExpresionEditorToolStripMenuItem.Text = "expresion editor"
        Me.ExpresionEditorToolStripMenuItem.Visible = False
        '
        'OpenQMFileDialog
        '
        Me.OpenQMFileDialog.Filter = "QM Design Files|*.qm"
        '
        'SaveHtmlDialog
        '
        Me.SaveHtmlDialog.Filter = "HTML file | *.html"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "qm"
        Me.SaveFileDialog1.Filter = "QM Files|*.qm"
        '
        'SaveDictonaryDialog
        '
        Me.SaveDictonaryDialog.Filter = "HTM file (Excel) | *.htm"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(218, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PreviewPropertyGridSplitter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.uxPreviewControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UxSection)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxQuestions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxlInformation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxCheckpoint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxVariable)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxStudy)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxQuestionnaireSet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxQuestionnaire)
        Me.SplitContainer1.Size = New System.Drawing.Size(566, 655)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 8
        '
        'PreviewPropertyGridSplitter
        '
        Me.PreviewPropertyGridSplitter.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.UI.My.MySettings.Default, "Main_PreviewProperyGridSplitter_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PreviewPropertyGridSplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.PreviewPropertyGridSplitter.Location = Global.UI.My.MySettings.Default.Main_PreviewProperyGridSplitter_Location
        Me.PreviewPropertyGridSplitter.Name = "PreviewPropertyGridSplitter"
        Me.PreviewPropertyGridSplitter.Size = New System.Drawing.Size(10, 655)
        Me.PreviewPropertyGridSplitter.TabIndex = 9
        Me.PreviewPropertyGridSplitter.TabStop = False
        '
        'uxPreviewControl
        '
        Me.uxPreviewControl.Location = New System.Drawing.Point(0, 3)
        Me.uxPreviewControl.Name = "uxPreviewControl"
        Me.uxPreviewControl.Size = New System.Drawing.Size(217, 655)
        Me.uxPreviewControl.TabIndex = 0
        '
        'uxQuestions
        '
        Me.uxQuestions.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxQuestions.Location = New System.Drawing.Point(-2025, 0)
        Me.uxQuestions.Name = "uxQuestions"
        Me.uxQuestions.Size = New System.Drawing.Size(338, 655)
        Me.uxQuestions.TabIndex = 7
        '
        'uxlInformation
        '
        Me.uxlInformation.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxlInformation.Location = New System.Drawing.Point(-1687, 0)
        Me.uxlInformation.Name = "uxlInformation"
        Me.uxlInformation.Size = New System.Drawing.Size(338, 655)
        Me.uxlInformation.TabIndex = 6
        '
        'uxCheckpoint
        '
        Me.uxCheckpoint.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxCheckpoint.Location = New System.Drawing.Point(-1349, 0)
        Me.uxCheckpoint.Name = "uxCheckpoint"
        Me.uxCheckpoint.Size = New System.Drawing.Size(338, 655)
        Me.uxCheckpoint.TabIndex = 5
        '
        'uxVariable
        '
        Me.uxVariable.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxVariable.Location = New System.Drawing.Point(-1011, 0)
        Me.uxVariable.Name = "uxVariable"
        Me.uxVariable.Size = New System.Drawing.Size(338, 655)
        Me.uxVariable.TabIndex = 4
        '
        'uxStudy
        '
        Me.uxStudy.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxStudy.Location = New System.Drawing.Point(-673, 0)
        Me.uxStudy.Name = "uxStudy"
        Me.uxStudy.Size = New System.Drawing.Size(338, 655)
        Me.uxStudy.TabIndex = 3
        '
        'uxQuestionnaireSet
        '
        Me.uxQuestionnaireSet.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxQuestionnaireSet.Location = New System.Drawing.Point(-335, 0)
        Me.uxQuestionnaireSet.Name = "uxQuestionnaireSet"
        Me.uxQuestionnaireSet.Size = New System.Drawing.Size(338, 655)
        Me.uxQuestionnaireSet.TabIndex = 1
        '
        'uxQuestionnaire
        '
        Me.uxQuestionnaire.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxQuestionnaire.Location = New System.Drawing.Point(3, 0)
        Me.uxQuestionnaire.Name = "uxQuestionnaire"
        Me.uxQuestionnaire.Size = New System.Drawing.Size(338, 655)
        Me.uxQuestionnaire.TabIndex = 0
        '
        'StructureControl1
        '
        Me.StructureControl1.DataBindings.Add(New System.Windows.Forms.Binding("Size", Global.UI.My.MySettings.Default, "Main_StructureControl1_Size", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StructureControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.StructureControl1.Location = New System.Drawing.Point(0, 27)
        Me.StructureControl1.Name = "StructureControl1"
        Me.StructureControl1.SelectedAdvNode = Nothing
        Me.StructureControl1.Size = Global.UI.My.MySettings.Default.Main_StructureControl1_Size
        Me.StructureControl1.TabIndex = 2
        '
        'UxSection
        '
        Me.UxSection.Dock = System.Windows.Forms.DockStyle.Right
        Me.UxSection.Location = New System.Drawing.Point(-2363, 0)
        Me.UxSection.Name = "UxSection"
        Me.UxSection.Size = New System.Drawing.Size(338, 655)
        Me.UxSection.TabIndex = 8
        Me.UxSection.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 682)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StructurePreviewSplitter)
        Me.Controls.Add(Me.StructureControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StructureControl1 As UI.StructureControl
    Friend WithEvents OpenQMFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LegalValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxPreviewControl As UI.PreviewControl
    Friend WithEvents StudyOutlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertyGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StructurePreviewSplitter As System.Windows.Forms.Splitter
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveHtmlDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseUpdaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataManagerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxLanguage As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LanguagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DictionaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByVariableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDictonaryDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MethodsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpresionEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDAReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents uxQuestionnaire As UI.CtlQuestionnaire
    Friend WithEvents uxQuestionnaireSet As UI.CtlQuestionnaireSet
    Friend WithEvents uxStudy As UI.CtlStudy
    Friend WithEvents uxVariable As UI.CtlVariable
    Friend WithEvents uxCheckpoint As UI.CtlCheckpoint
    Friend WithEvents uxlInformation As UI.CtlInformation
    Friend WithEvents uxQuestions As UI.CtlQuestions
    Friend WithEvents PreviewPropertyGridSplitter As System.Windows.Forms.Splitter
    Friend WithEvents UxSection As UI.CtlSection
End Class
