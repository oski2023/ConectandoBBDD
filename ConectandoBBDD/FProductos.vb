Public Class FProductos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Actualiza()

    End Sub




    Private Sub Actualiza()
        Me.ProductosTableAdapter.Fill(Me.PruebaDataSet.Productos)
    End Sub


    'configuracion del boton Agregar
    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProductosBindingSource.AddNew()
        CodigoTextBox.Focus()
    End Sub

    'configuracion del boton Eliminar
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        ProductosBindingSource.RemoveCurrent()
        ProductosTableAdapter.Update(PruebaDataSet.Productos)
        Actualiza()

    End Sub

    'configuracion del boton Guardar
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ProductosBindingSource.EndEdit()
        ProductosTableAdapter.Update(PruebaDataSet.Productos)
        Actualiza()

    End Sub

    'configuracion del boton Cancelar
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProductosBindingSource.CancelEdit()
    End Sub

    Private Sub TipoLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoComboBox.SelectedIndexChanged

    End Sub
End Class
