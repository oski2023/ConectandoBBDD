Public Class FMenu
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim MdiForm As New FProductos
        MdiForm.MdiParent = Me
        MdiForm.Show()





        'FProductos.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim MdiForm As New FClientes
        MdiForm.MdiParent = Me
        MdiForm.Show()
    End Sub
End Class