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
        Dim Animation4 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
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
        Me.txtCrearUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNyA = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtCrearContraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtCrearMail = New Guna.UI.WinForms.GunaTextBox()
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
        Me.pnlRegistrar.Controls.Add(Me.txtCrearUsuario)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel9)
        Me.pnlRegistrar.Controls.Add(Me.txtNyA)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel8)
        Me.pnlRegistrar.Controls.Add(Me.btnLogin)
        Me.pnlRegistrar.Controls.Add(Me.GunaGradientButton2)
        Me.pnlRegistrar.Controls.Add(Me.txtCrearContraseña)
        Me.pnlRegistrar.Controls.Add(Me.GunaLabel4)
        Me.pnlRegistrar.Controls.Add(Me.txtCrearMail)
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
        'txtCrearUsuario
        '
        Me.txtCrearUsuario.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearUsuario.BorderSize = 1
        Me.txtCrearUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearUsuario, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearUsuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCrearUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.txtCrearUsuario.Location = New System.Drawing.Point(296, 250)
        Me.txtCrearUsuario.Name = "txtCrearUsuario"
        Me.txtCrearUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrearUsuario.SelectedText = ""
        Me.txtCrearUsuario.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearUsuario.TabIndex = 12
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
        'txtNyA
        '
        Me.txtNyA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtNyA.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtNyA.BorderSize = 1
        Me.txtNyA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtNyA, Guna.UI.Animation.DecorationType.None)
        Me.txtNyA.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNyA.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNyA.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNyA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNyA.ForeColor = System.Drawing.Color.White
        Me.txtNyA.Location = New System.Drawing.Point(296, 175)
        Me.txtNyA.Name = "txtNyA"
        Me.txtNyA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNyA.SelectedText = ""
        Me.txtNyA.Size = New System.Drawing.Size(247, 37)
        Me.txtNyA.TabIndex = 10
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
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.trsLogintoRegister.SetDecoration(Me.GunaGradientButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(296, 462)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(247, 42)
        Me.GunaGradientButton2.TabIndex = 6
        Me.GunaGradientButton2.Text = "Registrarme"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCrearContraseña
        '
        Me.txtCrearContraseña.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearContraseña.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearContraseña.BorderSize = 1
        Me.txtCrearContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearContraseña, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearContraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCrearContraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearContraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearContraseña.ForeColor = System.Drawing.Color.White
        Me.txtCrearContraseña.Location = New System.Drawing.Point(296, 404)
        Me.txtCrearContraseña.Name = "txtCrearContraseña"
        Me.txtCrearContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCrearContraseña.SelectedText = ""
        Me.txtCrearContraseña.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearContraseña.TabIndex = 5
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
        'txtCrearMail
        '
        Me.txtCrearMail.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtCrearMail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.txtCrearMail.BorderSize = 1
        Me.txtCrearMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.trsLogintoRegister.SetDecoration(Me.txtCrearMail, Guna.UI.Animation.DecorationType.None)
        Me.txtCrearMail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCrearMail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrearMail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrearMail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCrearMail.ForeColor = System.Drawing.Color.White
        Me.txtCrearMail.Location = New System.Drawing.Point(296, 327)
        Me.txtCrearMail.Name = "txtCrearMail"
        Me.txtCrearMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrearMail.SelectedText = ""
        Me.txtCrearMail.Size = New System.Drawing.Size(247, 37)
        Me.txtCrearMail.TabIndex = 3
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
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 1.0!
        Me.trsLogintoRegister.DefaultAnimation = Animation4
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
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtCrearContraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtCrearMail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtCrearUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNyA As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents trsLogintoRegister As Guna.UI.WinForms.GunaTransition
    Friend WithEvents dragLogin As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents dragRegister As Guna.UI.WinForms.GunaDragControl
End Class
