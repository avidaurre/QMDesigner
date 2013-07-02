Imports BO
Public Class CtlQuestions

    Public Sub PopulateQuestion(ByVal Tag As BO.Question)
        'Valid if the data are empty or Null

        If (Tag.Name = Nothing) Then
            Me.TxtName.Text = String.Empty
        Else
            Me.TxtName.Text = Tag.Name.ToString()
        End If

        If (Tag.MainText = Nothing) Then
            Me.TxtMainText.Text = String.Empty
        Else
            Me.TxtMainText.Text = Tag.MainText.ToString()
        End If

        If (Tag.Comment = Nothing) Then
            Me.TxtComment.Text = String.Empty
        Else
            Me.TxtComment.Text = Tag.Comment.ToString()
        End If

        If (Tag.VariableName = Nothing) Then
            Me.TxtVarName.Text = String.Empty
        Else
            Me.TxtVarName.Text = Tag.VariableName.ToString()
        End If

        If (Tag.DataType = Nothing) Then
            Me.TxtDataType.Text = String.Empty
        Else
            Me.TxtDataType.Text = Tag.DataType.ToString()
        End If

        If (Tag.AbsoluteMaximum = Nothing) Then
            Me.TxtAbsMax.Text = String.Empty
        Else
            Me.TxtAbsMax.Text = Tag.AbsoluteMaximum.ToString()
        End If

        If (Tag.AbsoluteMinimum = Nothing) Then
            Me.TxtAbsMin.Text = String.Empty
        Else
            Me.TxtAbsMin.Text = Tag.AbsoluteMinimum.ToString()
        End If

        If (Tag.PromptOver = Nothing) Then
            Me.TxtPromptOver.Text = String.Empty
        Else
            Me.TxtPromptOver.Text = Tag.PromptOver.ToString()
        End If

        If (Tag.PromptUnder = Nothing) Then
            Me.TxtPromptUnder.Text = String.Empty
        Else
            Me.TxtPromptUnder.Text = Tag.PromptUnder.ToString()
        End If

        If (Tag.GroupText = Nothing) Then
            Me.TxtGroupText.Text = String.Empty
        Else
            Me.TxtGroupText.Text = Tag.GroupText.ToString()
        End If

        If (Tag.CustomValidationFailMessage = Nothing) Then
            Me.TxtCustomMss.Text = String.Empty
        Else
            Me.TxtCustomMss.Text = Tag.CustomValidationFailMessage.ToString()
        End If

        If (Tag.CustomValidation = Nothing) Then
            Me.TxtCustomValidation.Text = String.Empty
        Else
            Me.TxtCustomValidation.Text = Tag.CustomValidation.ToString()
        End If

        If (Tag.OnChange = Nothing) Then
            Me.TxtOnChange.Text = String.Empty
        Else
            Me.TxtOnChange.Text = Tag.OnChange.ToString()
        End If

        If (Tag.OnLoad = Nothing) Then
            Me.TxtOnLoad.Text = String.Empty
        Else
            Me.TxtOnLoad.Text = Tag.OnLoad.ToString()
        End If

        If (Tag.OnUnload = Nothing) Then
            Me.TxtOnUnload.Text = String.Empty
        Else
            Me.TxtOnUnload.Text = Tag.OnUnload.ToString()
        End If

        If (Tag.HelpText = Nothing) Then
            Me.TxtHelpText.Text = String.Empty
        Else
            Me.TxtHelpText.Text = Tag.HelpText.ToString()
        End If

        If (Tag.Arguments = Nothing) Then
            Me.TxtArguments.Text = String.Empty
        Else
            Me.TxtArguments.Text = Tag.Arguments.ToString()
        End If

        If (Tag.QuestionnaireID = Nothing) Then
            Me.LblQuesID.Text = 0
        Else
            Me.LblQuesID.Text = Tag.QuestionnaireID.ToString()
        End If

        If (Tag.QuestionnaireSetID = Nothing) Then
            Me.LblQuesSetID.Text = 0
        Else
            Me.LblQuesSetID.Text = Tag.QuestionnaireSetID.ToString()
        End If

        If (Tag.SectionID = Nothing) Then
            Me.LblSectionID.Text = 0
        Else
            Me.LblSectionID.Text = Tag.SectionID.ToString()
        End If

        If (Tag.Guid = Nothing) Then
            Me.LblUniqueID.Text = 0
        Else
            Me.LblUniqueID.Text = Tag.Guid.ToString()
        End If

        Me.CmbLegalValue.Text = Tag.LegalValueTable.ToString()
        Me.CmbScreenTem.Text = Tag.ScreenTemplate.ToString()
        Me.CmbVarScope.Text = Tag.VariableScope.ToString()
        Me.CmbGroupMem.Text = Tag.GroupMember.ToString()
        Me.CmbShowQuestion.Text = Tag.Visible.ToString()
        Me.CmbAnswerReq.Text = Tag.Required.ToString()
        Me.CmbConfBack.Text = Tag.ConfirmBack.ToString()
        Me.CmbConfChange.Text = Tag.ConfirmChange.ToString()
        Me.CmbConfNext.Text = Tag.ConfirmNext.ToString()
        Me.CmbHideBack.Text = Tag.HideBack.ToString()
        Me.CmbHideNext.Text = Tag.HideNext.ToString()

    End Sub

#Region "CtlQuestion Click Events"
    Private Sub btnComment_Click(sender As System.Object, e As System.EventArgs) Handles btnComment.Click
        TxtComment.Text = CodeEditorForm.GetString(TxtComment.Text)
    End Sub

    Private Sub BtnMainText_Click(sender As System.Object, e As System.EventArgs) Handles BtnMainText.Click
        TxtMainText.Text = CodeEditorForm.GetString(TxtMainText.Text)
    End Sub

    Private Sub CtlQuestions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnName_Click(sender As System.Object, e As System.EventArgs) Handles btnName.Click
        TxtName.Text = CodeEditorForm.GetString(TxtName.Text)
    End Sub

    Private Sub BtnGroupText_Click(sender As System.Object, e As System.EventArgs) Handles BtnGroupText.Click
        TxtGroupText.Text = CodeEditorForm.GetString(TxtGroupText.Text)
    End Sub

    Private Sub BtnCustomMss_Click(sender As System.Object, e As System.EventArgs) Handles BtnCustomMss.Click
        TxtCustomMss.Text = CodeEditorForm.GetString(TxtCustomMss.Text)
    End Sub

    Private Sub BtnCustomValidate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCustomValidate.Click
        TxtCustomValidation.Text = CodeEditorForm.GetString(TxtCustomValidation.Text)
    End Sub

    Private Sub BtnOnChange_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnChange.Click
        TxtOnChange.Text = CodeEditorForm.GetString(TxtOnChange.Text)
    End Sub

    Private Sub BtnOnLoad_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnLoad.Click
        TxtOnLoad.Text = CodeEditorForm.GetString(TxtOnLoad.Text)
    End Sub

    Private Sub BtnOnUnload_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnUnload.Click
        TxtOnUnload.Text = CodeEditorForm.GetString(TxtOnUnload.Text)
    End Sub

#End Region


    Private Sub BtnHelpText_Click(sender As System.Object, e As System.EventArgs) Handles BtnHelpText.Click
        TxtHelpText.Text = CodeEditorForm.GetString(TxtHelpText.Text)
    End Sub
End Class
