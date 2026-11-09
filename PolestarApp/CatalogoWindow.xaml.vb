Class CatalogoWindow
    Private menuAbierto As Boolean = False

    Private Sub BtnMenu_Click(sender As Object, e As RoutedEventArgs) Handles BtnMenu.Click
        Dim nombre As String = If(menuAbierto, "CerrarMenu", "AbrirMenu")
        Dim animacion = CType(FindResource(nombre), System.Windows.Media.Animation.Storyboard)
        animacion.Begin(Me)
        menuAbierto = Not menuAbierto
    End Sub

    ' Cierra la tendina si esta abierta (se usa al elegir la pagina en la que ya estamos)
    Private Sub CerrarTendina()
        If menuAbierto Then
            CType(FindResource("CerrarMenu"), System.Windows.Media.Animation.Storyboard).Begin(Me)
            menuAbierto = False
        End If
    End Sub

    ' Abre otra ventana y cierra la actual
    Private Sub IrA(ventana As Window)
        ventana.Show()
        Me.Close()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As RoutedEventArgs) Handles BtnInicio.Click
        IrA(New MainWindow())
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As RoutedEventArgs) Handles BtnCatalogo.Click
        CerrarTendina()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As RoutedEventArgs) Handles BtnLogin.Click
        IrA(New LoginWindow())
    End Sub
End Class
