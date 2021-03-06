Public Class ListEditorFrm


#Region "Properties"

    Private elements As IList
    Private itemType As Type
    Private dimmedProperty As Reflection.PropertyInfo
    Private uniqueProperty As Reflection.PropertyInfo
    Private autoSort As Boolean
    Private closeWithDoubleClick As Boolean


    ''' <summary>
    ''' Gets or sets the selected item in the list.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Property SelectedItem() As Object
        Get
            Return Me.uxListBox.SelectedNode.Tag
        End Get
        Set(ByVal value As Object)

            For Each node As DevComponents.AdvTree.Node In Me.uxListBox.Nodes

                If node.Tag.Equals(value) Then

                    uxListBox.SelectedNode = node
                    Exit Property

                End If

            Next

            uxListBox.SelectedNode = Nothing

        End Set
    End Property

#End Region



#Region "Methods"


    ''' <summary>
    ''' Constructor: Init values, sorts the input list.
    ''' </summary>
    ''' <param name="input"></param>
    ''' <param name="itemType"></param>
    ''' <param name="title"></param>
    ''' <remarks></remarks>

    Public Sub New(ByRef input As IList, ByVal itemType As Type, ByVal title As String, ByVal DimmedProperty As Reflection.PropertyInfo, ByVal UniqueProperty As Reflection.PropertyInfo, ByVal AutoSort As Boolean, ByVal closeWithDoubleClick As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dimmedProperty = DimmedProperty
        Me.uniqueProperty = UniqueProperty
        Me.autoSort = AutoSort
        Me.closeWithDoubleClick = closeWithDoubleClick
        Dim values As New List(Of Object)
        elements = input
        Me.itemType = itemType
        Me.Text = title


        For Each element As Object In input

            AddItemIntoList(element)

        Next

        If Me.autoSort Then uxListBox.Nodes.Sort()

    End Sub


    ''' <summary>
    ''' Wraps the value in a node and adds it into the tree.
    ''' </summary>
    ''' <param name="value">Object to be added</param>
    ''' <remarks></remarks>

    Private Sub AddItemIntoList(ByVal value As Object)

        Dim node As New DevComponents.AdvTree.Node(value.ToString)
        node.Tag = value
        If Me.dimmedProperty IsNot Nothing AndAlso CBool(Me.dimmedProperty.GetValue(node.Tag, Nothing)) Then
            node.Style = uxListBox.Styles("DimmedStyle")
        Else
            node.Style = uxListBox.Styles("DefaultStyle")
        End If

        uxListBox.Nodes.Add(node)

    End Sub


    ''' <summary>
    ''' Moves the changed values to the InputList.
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub UpdateInputList()

        elements.Clear()

        For Each node As DevComponents.AdvTree.Node In uxListBox.Nodes

            elements.Add(node.Tag)

        Next

    End Sub

#End Region



#Region "Event handlers"

    ''' <summary>
    ''' Search button click.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        For Each node As DevComponents.AdvTree.Node In uxListBox.Nodes

            node.Visible = node.Text.ToLower.Contains(ToolStripTextBox1.Text.ToLower)

        Next

    End Sub


    ''' <summary>
    ''' Add button click.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        ' Create and add.
        Dim value As Object = itemType.GetConstructor(New Type() {}).Invoke(Nothing)
        AddItemIntoList(value)
        ' Focus.
        Me.SelectedItem = value
    End Sub


    ''' <summary>
    ''' Remove button click.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If uxListBox.SelectedNode IsNot Nothing Then
            If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                uxListBox.SelectedNode.Remove()

            End If
        End If

    End Sub


    ''' <summary>
    ''' Before the node is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Validates the previous selection.</remarks>

    Private Sub uxListBox_BeforeNodeSelect(ByVal sender As System.Object, ByVal e As DevComponents.AdvTree.AdvTreeNodeCancelEventArgs) Handles uxListBox.BeforeNodeSelect

        If AdvPropertyGrid1.SelectedObject IsNot Nothing AndAlso AdvPropertyGrid1.SelectedObject.GetType().GetInterface("ISelfValidate") IsNot Nothing Then

            e.Cancel = Not CType(AdvPropertyGrid1.SelectedObject, ISelfValidate).IsValid()

        End If

    End Sub

    ''' <summary>
    ''' After a node is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub uxListBox_AfterNodeSelect(ByVal sender As System.Object, ByVal e As DevComponents.AdvTree.AdvTreeNodeEventArgs) Handles uxListBox.AfterNodeSelect

        If uxListBox.SelectedNode Is Nothing Then

            AdvPropertyGrid1.SelectedObject = Nothing

        Else

            AdvPropertyGrid1.SelectedObject = uxListBox.SelectedNode.Tag

        End If

    End Sub


    ''' <summary>
    ''' After a value changed in the property grid.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub AdvPropertyGrid1_PropertyValueChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles AdvPropertyGrid1.PropertyValueChanged

        uxListBox.SelectedNode.Text = uxListBox.SelectedNode.Tag.ToString()
        If Me.dimmedProperty IsNot Nothing AndAlso Me.dimmedProperty.GetValue(uxListBox.SelectedNode.Tag, Nothing) Then
            uxListBox.SelectedNode.Style = uxListBox.Styles("DimmedStyle")
        Else
            uxListBox.SelectedNode.Style = uxListBox.Styles("DefaultStyle")
        End If
        If Me.autoSort Then uxListBox.Nodes.Sort()

    End Sub


    ''' <summary>
    ''' Property value changing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Validate if the unique property stills unique.</remarks>

    Private Sub AdvPropertyGrid1_PropertyValueChanging(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.PropertyValueChangingEventArgs) Handles AdvPropertyGrid1.PropertyValueChanging

        If Me.uniqueProperty IsNot Nothing AndAlso e.PropertyName = Me.uniqueProperty.Name Then

            For Each node As DevComponents.AdvTree.Node In uxListBox.Nodes

                If Not node.Tag.Equals(AdvPropertyGrid1.SelectedObject) AndAlso Me.uniqueProperty.GetValue(node.Tag, Nothing).Equals(e.NewValue) Then
                    Dim message As String = String.Format("There is another object with the same value for the property '{0}'. Are you sure you want to use this value again?", Me.uniqueProperty.Name)
                    e.Handled = (MessageBox.Show(message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No)
                    Exit Sub
                End If

            Next

        End If

    End Sub


    ''' <summary>
    ''' When an item in the list is double clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub uxListBox_NodeDoubleClick(ByVal sender As System.Object, ByVal e As DevComponents.AdvTree.TreeNodeMouseEventArgs) Handles uxListBox.NodeDoubleClick

        If Me.closeWithDoubleClick Then Me.Close()

    End Sub


    ''' <summary>
    ''' Form Closing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ListEditorFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If AdvPropertyGrid1.SelectedObject IsNot Nothing AndAlso AdvPropertyGrid1.SelectedObject.GetType().GetInterface("ISelfValidate") IsNot Nothing Then

            e.Cancel = Not CType(AdvPropertyGrid1.SelectedObject, ISelfValidate).IsValid()

        End If

    End Sub


#End Region


End Class