Imports System.Transactions

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'ListBox1.Items.Add("Xiaomi")
        Dim newItem
        newItem = InputBox("Enter your favourite phone ")
        ListBox1.Items.Add(newItem)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'ListBox1.Items.Remove("iPhone")
        Dim oldItem
        oldItem = InputBox("Enter the name of the Item you want to remove/delete ")
        ListBox1.Items.Remove(oldItem)
    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
