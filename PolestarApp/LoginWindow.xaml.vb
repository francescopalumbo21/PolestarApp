Class LoginWindow
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
        IrA(New CatalogoWindow())
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As RoutedEventArgs) Handles BtnLogin.Click
        CerrarTendina()
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As RoutedEventArgs) Handles BtnEntrar.Click
        Dim correo As String = TxtCorreo.Text.Trim()
        Dim contrasena As String = PwdContrasena.Password
        TxtError.Visibility = Visibility.Collapsed

        If correo = "" Then
            MostrarError("Introduce tu correo electrónico.", TxtCorreo)
        ElseIf Not correo.Contains("@") OrElse Not correo.Contains(".") Then
            MostrarError("El correo no tiene un formato válido.", TxtCorreo)
        ElseIf contrasena = "" Then
            MostrarError("Introduce tu contraseña.", PwdContrasena)
        ElseIf correo <> "cliente@polestar.es" OrElse contrasena <> "Polestar2026" Then
            PwdContrasena.Clear()
            MostrarError("Correo o contraseña incorrectos.", PwdContrasena)
        Else
            MessageBox.Show("Bienvenido a Polestar.", "Sesión iniciada",
                            MessageBoxButton.OK, MessageBoxImage.Information)
            IrA(New MainWindow())
        End If
    End Sub

    Private Sub MostrarError(mensaje As String, campo As Control)
        TxtError.Text = mensaje
        TxtError.Visibility = Visibility.Visible
        campo.Focus()
    End Sub

    Private Sub Campos_Cambian(sender As Object, e As RoutedEventArgs) Handles TxtCorreo.TextChanged, PwdContrasena.PasswordChanged
        TxtError.Visibility = Visibility.Collapsed
    End Sub

    Private Sub TxtOlvido_Click(sender As Object, e As MouseButtonEventArgs) Handles TxtOlvido.MouseLeftButtonUp
        MessageBox.Show("Para restablecer tu contraseña, contacta con tu concesionario Polestar.",
                        "Recuperar contraseña", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub
End Class
