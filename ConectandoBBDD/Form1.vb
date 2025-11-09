Public Class Form1
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PruebaDataSet.Productos)

    End Sub
End Class
