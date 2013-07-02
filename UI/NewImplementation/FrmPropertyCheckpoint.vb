Imports BO

Public Class FrmPropertyCheckpoint

    Private _propertyCheckpoint As Object


    Public Shared Function Execute(ByVal emptyObject As BO.CheckPoint) As BO.GenericObject

        ' Execute the Editor and return the generic object'
        Dim form As New FrmPropertyCheckpoint(emptyObject)
        If form.ShowDialog = Windows.Forms.DialogResult.OK Then
            form.PopulateCheckPoint(emptyObject)
            Return emptyObject
        Else
            Return Nothing
        End If
    End Function

    Public Sub New(ByVal emptyObject As BO.CheckPoint)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This moves the data to the object in the form'
        Me.CmbBranch.Text = CmbBranch.Items(0)
        Me.LblQuesID.Text = emptyObject.QuestionnaireID.ToString()
        Me.LblQuesSetID.Text = emptyObject.QuestionnaireSetID.ToString()
        Me.LblSectionID.Text = emptyObject.SectionID.ToString()
        Me.LblUniqueID.Text = emptyObject.Guid.ToString()

    End Sub

    Public Function PopulateCheckPoint(ByVal ObjectToPopulate As BO.CheckPoint) As Boolean

        ObjectToPopulate.Name = Me.TxtName.Text
        ObjectToPopulate.MainText = Me.TxtMainText.Text
        ObjectToPopulate.BranchIf = Me.CmbBranch.Text
        ObjectToPopulate.Condition = Me.TxtCondition.Text
        ObjectToPopulate.Comment = Me.TxtComment.Text

    End Function


    Private Sub PropertyCheckpoint_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgValue As String = String.Empty

        If Me.DialogResult = Windows.Forms.DialogResult.OK Then

            If String.IsNullOrEmpty(Me.TxtMainText.Text) Then msgValue &= Environment.NewLine & "Main text is required."
            If String.IsNullOrEmpty(Me.TxtCondition.Text) Then msgValue &= Environment.NewLine & "Condition is required."
            If String.IsNullOrEmpty(Me.CmbBranch.Text) Then msgValue &= Environment.NewLine & "BranchIf is required."

            If Not String.IsNullOrEmpty(msgValue) Then
                MessageBox.Show("Error list:" & msgValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnName.Click
        TxtName.Text = CodeEditorForm.GetString(TxtName.Text)
    End Sub

    Private Sub BtnMainText_Click(sender As System.Object, e As System.EventArgs) Handles BtnMainText.Click
        TxtMainText.Text = CodeEditorForm.GetString(TxtMainText.Text)
    End Sub

    Private Sub BtnComment_Click(sender As System.Object, e As System.EventArgs) Handles BtnComment.Click
        TxtComment.Text = CodeEditorForm.GetString(TxtComment.Text)
    End Sub

    Private Sub BtnCondition_Click(sender As System.Object, e As System.EventArgs) Handles BtnCondition.Click
        TxtCondition.Text = CodeEditorForm.GetString(TxtCondition.Text)
    End Sub
End Class