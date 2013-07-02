Imports BO
Public Class FrmPropertyInformation

    Public Shared Function Execute(ByVal emptyObject As BO.GenericObject) As BO.GenericObject

        ' Execute the Editor and return the generic object'
        Dim form As New FrmPropertyInformation(emptyObject)
        If form.ShowDialog = Windows.Forms.DialogResult.OK Then
            form.PopulateQuestions(emptyObject)
            Return emptyObject
        Else
            Return Nothing
        End If
    End Function

    Public Sub New(ByVal emptyObject As BO.Information)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This set a default value in the ComboBox

        Me.CmbHideBack.Text = CmbHideBack.Items(1)
        Me.CmbHideNext.Text = CmbHideNext.Items(1)
        Me.CmbVisible.Text = CmbVisible.Items(0)

        ' This moves the data to the object in the form'
        Me.LblQuesID.Text = emptyObject.QuestionnaireID.ToString()
        Me.LblQuesSetID.Text = emptyObject.QuestionnaireSetID.ToString()
        Me.LblSectionID.Text = emptyObject.SectionID.ToString()
        Me.LblUniqueID.Text = emptyObject.Guid.ToString()
    End Sub

    Public Function PopulateQuestions(ByVal ObjectToPopulate As BO.Information) As Boolean

        ' Update Main Data
        ObjectToPopulate.Name = Me.TxtName.Text
        ObjectToPopulate.MainText = Me.TxtMainText.Text
        ObjectToPopulate.Comment = Me.TxtComment.Text
        'Update PDA_Action Data
        ObjectToPopulate.OnLoad = Me.TxtOnLoad.Text
        ObjectToPopulate.OnUnload = Me.TxtOnUnload.Text
        'Update PDA_Settings
        ObjectToPopulate.HideBack = Me.CmbHideBack.Text
        ObjectToPopulate.HideNext = Me.CmbHideNext.Text
        ObjectToPopulate.Visible = Me.CmbVisible.Text
    End Function

    Private Sub BtnName_Click(sender As System.Object, e As System.EventArgs) Handles BtnName.Click
        TxtName.Text = CodeEditorForm.GetString(TxtName.Text)
    End Sub

    Private Sub BtnMainText_Click(sender As System.Object, e As System.EventArgs) Handles BtnMainText.Click
        TxtMainText.Text = CodeEditorForm.GetString(TxtMainText.Text)
    End Sub

    Private Sub BtnComment_Click(sender As System.Object, e As System.EventArgs) Handles BtnComment.Click
        TxtComment.Text = CodeEditorForm.GetString(TxtComment.Text)
    End Sub

    Private Sub BtnOnLoad_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnLoad.Click
        TxtOnLoad.Text = CodeEditorForm.GetString(TxtOnLoad.Text)
    End Sub

    Private Sub BtnOnUnload_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnUnload.Click
        TxtOnUnload.Text = CodeEditorForm.GetString(TxtOnUnload.Text)
    End Sub
End Class