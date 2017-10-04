Public Class Form1
    ''' <summary>
    ''' Evento causado por el click del boton saludo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaludo_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        Dim nombre As String
        nombre = Me.txtNombre.Text

        '/MessageBox.Show("hola " + nombre, "Saludo")
        MessageBox.Show(String.Format("holaaa (0)"), "saludo")
        MessageBox.Show($"hola {nombre}")




    End Sub
End Class
