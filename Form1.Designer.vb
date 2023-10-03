<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New Windows.Forms.ListBox()
        btnAdd = New Button()
        btnDeleteSelected = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Items.AddRange(New Object() {"iPhone", "Huawei", "Samsung"})
        ListBox1.Location = New Point(132, 43)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(255, 324)
        ListBox1.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(445, 43)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(124, 37)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteSelected
        ' 
        btnDeleteSelected.Location = New Point(445, 156)
        btnDeleteSelected.Name = "btnDeleteSelected"
        btnDeleteSelected.Size = New Size(124, 42)
        btnDeleteSelected.TabIndex = 1
        btnDeleteSelected.Text = "Delete Selected"
        btnDeleteSelected.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(445, 99)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(124, 37)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(445, 218)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(124, 37)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(366, 399)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnDeleteSelected)
        Controls.Add(btnAdd)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "ListBox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
