<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrom
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrom))
        Me.pnlLogin = New Guna.UI.WinForms.GunaPanel()
        Me.btnRegistrarses = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btnIngresar = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPwd = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblnombre = New Guna.UI.WinForms.GunaLabel()
        Me.pnlRegistrar = New Guna.UI.WinForms.GunaPanel()
        Me.btnRegistrarme = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtCrearContrasena = New Guna.UI.WinForms.GunaTextBox()
        Me.txtCrearCorreo = New Guna.UI.WinForms.GunaTextBox()
        Me.txtCrearUsr = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNomAp = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.trsLogintoRegister = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.dragLogin = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dragRegister = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegistrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnRegistrarses)
        Me.pnlLogin.Controls.Add(Me.GunaLinkLabel1)
        Me.pnlLogin.Controls.Add(Me.btnIngresar)
        Me.pnlLogin.Controls.Add(Me.txtPwd)
        Me.pnlLogin.Controls.Add(Me.GunaLabel3)
        Me.pnlLogin.Controls.Add(Me.txtUsuario)
        Me.pnlLogin.Controls.Add(Me.GunaLabel2)
        Me.pnlLogin.Controls.Add(Me.GunaLabel1)
        Me.pnlLogin.Controls.Add(Me.lblnombre)
        Me.trsLogintoRegister.SetDecoration(Me.pnlLogin, Guna.UI.Animation.DecorationType.None)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(846, 529)
        Me.pnlLogin.TabIndex = 0
        '
        'btnRegistrarses
        '
        Me.btnRegistrarses.AnimationHoverSpeed = 0.07!
        Me.btnRegistrarses.AnimationSpeed = 0.03!
        Me.btnRegistrarses.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnRegistrarses.BorderColor = System.Drawing.Color.Black
        Me.trsLogintoRegister.SetDecoration(Me.btnRegistrarses, Guna.UI.Animation.DecorationType.None)
        Me.btnRegistrarses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrarses.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrarses.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRegistrarses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRegistrarses.Image = CType(resources.GetObject("btnRegistrarses.Image"), System.Drawing.Image)
        Me.btnRegistrarses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRegistrarses.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnRegistrarses.Location = New System.Drawing.Point(671, 12)
        Me.btnRegistrarses.Name = "btnRegistrarses"
        Me.btnRegistrarses.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnRegistrarses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrarses.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrarses.OnHoverImage = CType(resources.GetObject("btnRegistrarses.OnHoverImage"), System.Drawing.Image)
        Me.btnRegistrarses.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrarses.Size = New System.Drawing.Size(163, 42)
        Me.btnRegistrarses.TabIndex = 8
        Me.btnRegistrarses.Text = "Crear una cuenta"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel1.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLinkLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(361, 358)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(119, 15)
        Me.GunaLinkLabel1.TabIndex = 7
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Olvidé mi contraseña"
        '
        'btnIngresar
        '
        Me.btnIngresar.AnimationHoverSpeed = 0.07!
        Me.btnIngresar.AnimationSpeed = 0.03!
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnIngresar.BorderColor = System.Drawing.Color.Black
        Me.trsLogintoRegister.SetDecoration(Me.btnIngresar, Guna.UI.Animation.DecorationType.None)
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresar.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Image = Nothing
        Me.btnIngresar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnIngresar.Location = New System.Drawing.Point(296, 304)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnIngresar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresar.OnHoverImage = Nothing
        Me.btnIngresar.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresar.Radius = 2
        Me.btnIngresar.Size = New System.Drawing.Size(247, 42)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPwd
        '
        Me.txtPwd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtPwd.BorderSize = 1
        Me.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtPwd, Guna.UI.Animation.DecorationType.None)
        Me.txtPwd.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtPwd.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPwd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPwd.ForeColor = System.Drawing.Color.White
        Me.txtPwd.Location = New System.Drawing.Point(296, 250)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.SelectedText = ""
        Me.txtPwd.Size = New System.Drawing.Size(247, 37)
        Me.txtPwd.TabIndex = 5
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(292, 227)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(83, 20)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtUsuario.BorderSize = 1
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtUsuario, Guna.UI.Animation.DecorationType.None)
        Me.txtUsuario.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(296, 175)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(247, 37)
        Me.txtUsuario.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(292, 152)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(197, 20)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Usuario o correo electrónico"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(292, 94)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(188, 20)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Ingrese a su tienda favorita"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.lblnombre, Guna.UI.Animation.DecorationType.None)
        Me.lblnombre.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.Color.White
        Me.lblnombre.Location = New System.Drawing.Point(291, 66)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(282, 28)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Panel de ingreso a Webstore"
        '
        'pnlRegistrar
        '
        Me.pnlRegistrar.Controls.Add(Me.btnRegistrarme)
        Me.pnlRegistrar.Controls.Add(Me.txtCrearContrasena)
        Me.pnlRegistrar.Controls.Add(Me.txtCrearCorreo)
        Me.pnlRegistrar.Controls.Add(Me.txtCrearUsr)
        Me.pnlRegistrar.Controls.Add(Me.txtNomAp)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel9)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel8)
        Me.pnlRegistrar.Controls.Add(Me.btnLogin)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel4)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel5)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel6)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel7)
        Me.trsLogintoRegister.SetDecoration(Me.pnlRegistrar, Guna.UI.Animation.DecorationType.None)
        Me.pnlRegistrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRegistrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegistrar.Name = "pnlRegistrar"
        Me.pnlRegistrar.Size = New System.Drawing.Size(846, 529)
        Me.pnlRegistrar.TabIndex = 1
        '
        'btnRegistrarme
        '
        Me.btnRegistrarme.AnimationHoverSpeed = 0.07!
        Me.btnRegistrarme.AnimationSpeed = 0.03!
        Me.btnRegistrarme.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarme.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrarme.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRegistrarme.BorderColor = System.Drawing.Color.Black
        Me.trsLogintoRegister.SetDecoration(Me.btnRegistrarme, Guna.UI.Animation.DecorationType.None)
        Me.btnRegistrarme.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrarme.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrarme.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRegistrarme.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarme.Image = Nothing
        Me.btnRegistrarme.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrarme.Location = New System.Drawing.Point(296, 461)
        Me.btnRegistrarme.Name = "btnRegistrarme"
        Me.btnRegistrarme.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRegistrarme.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegistrarme.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrarme.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrarme.OnHoverImage = Nothing
        Me.btnRegistrarme.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrarme.Radius = 2
        Me.btnRegistrarme.Size = New System.Drawing.Size(247, 42)
        Me.btnRegistrarme.TabIndex = 25
        Me.btnRegistrarme.Text = "Registrarme"
        Me.btnRegistrarme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCrearContrasena
        '
        Me.txtCrearContrasena.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearContrasena.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearContrasena.BorderSize = 1
        Me.txtCrearContrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearContrasena, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearContrasena.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtCrearContrasena.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearContrasena.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearContrasena.ForeColor = System.Drawing.Color.White
        Me.txtCrearContrasena.Location = New System.Drawing.Point(296, 404)
        Me.txtCrearContrasena.Name = "txtCrearContrasena"
        Me.txtCrearContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrearContrasena.SelectedText = ""
        Me.txtCrearContrasena.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearContrasena.TabIndex = 24
        '
        'txtCrearCorreo
        '
        Me.txtCrearCorreo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearCorreo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearCorreo.BorderSize = 1
        Me.txtCrearCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearCorreo, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearCorreo.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtCrearCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCrearCorreo.Location = New System.Drawing.Point(296, 327)
        Me.txtCrearCorreo.Name = "txtCrearCorreo"
        Me.txtCrearCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrearCorreo.SelectedText = ""
        Me.txtCrearCorreo.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearCorreo.TabIndex = 23
        '
        'txtCrearUsr
        '
        Me.txtCrearUsr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearUsr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearUsr.BorderSize = 1
        Me.txtCrearUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearUsr, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearUsr.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtCrearUsr.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearUsr.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearUsr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearUsr.ForeColor = System.Drawing.Color.White
        Me.txtCrearUsr.Location = New System.Drawing.Point(296, 250)
        Me.txtCrearUsr.Name = "txtCrearUsr"
        Me.txtCrearUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrearUsr.SelectedText = ""
        Me.txtCrearUsr.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearUsr.TabIndex = 22
        '
        'txtNomAp
        '
        Me.txtNomAp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtNomAp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtNomAp.BorderSize = 1
        Me.txtNomAp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtNomAp, Guna.UI.Animation.DecorationType.None)
        Me.txtNomAp.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtNomAp.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomAp.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNomAp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNomAp.ForeColor = System.Drawing.Color.White
        Me.txtNomAp.Location = New System.Drawing.Point(296, 175)
        Me.txtNomAp.Name = "txtNomAp"
        Me.txtNomAp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomAp.SelectedText = ""
        Me.txtNomAp.Size = New System.Drawing.Size(247, 37)
        Me.txtNomAp.TabIndex = 21
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel9, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(292, 227)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(137, 20)
        Me.GunaLabel9.TabIndex = 11
        Me.GunaLabel9.Text = "Nombre de usuario"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel8, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(292, 152)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(136, 20)
        Me.GunaLabel8.TabIndex = 9
        Me.GunaLabel8.Text = "Nombre y Apellido"
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.trsLogintoRegister.SetDecoration(Me.btnLogin, Guna.UI.Animation.DecorationType.None)
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnLogin.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnLogin.Location = New System.Drawing.Point(747, 12)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = CType(resources.GetObject("btnLogin.OnHoverImage"), System.Drawing.Image)
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Size = New System.Drawing.Size(87, 42)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Ingresar"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(292, 381)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(83, 20)
        Me.GunaLabel4.TabIndex = 4
        Me.GunaLabel4.Text = "Contraseña"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(292, 304)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(132, 20)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "Correo electronico"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(292, 94)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(166, 20)
        Me.GunaLabel6.TabIndex = 1
        Me.GunaLabel6.Text = "Únase a la mejor tienda"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.trsLogintoRegister.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(291, 66)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(276, 28)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "Cree su cuenta en Webstore"
        '
        'trsLogintoRegister
        '
        Me.trsLogintoRegister.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.trsLogintoRegister.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.trsLogintoRegister.DefaultAnimation = Animation1
        Me.trsLogintoRegister.MaxAnimationTime = 200
        '
        'dragLogin
        '
        Me.dragLogin.TargetControl = Me.pnlLogin
        '
        'dragRegister
        '
        Me.dragRegister.TargetControl = Me.pnlRegistrar
        '
        'LoginFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 529)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegistrar)
        Me.trsLogintoRegister.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginFrom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Register"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlRegistrar.ResumeLayout(False)
        Me.pnlRegistrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogin As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtPwd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblnombre As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnRegistrarses As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents pnlRegistrar As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents trsLogintoRegister As Guna.UI.WinForms.GunaTransition
    Friend WithEvents dragLogin As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents dragRegister As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents txtCrearContrasena As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtCrearCorreo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtCrearUsr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNomAp As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnRegistrarme As Guna.UI.WinForms.GunaGradientButton
End Class
