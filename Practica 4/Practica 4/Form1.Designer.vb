<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.horas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Config = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Config, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.horas.Location = New System.Drawing.Point(396, 194)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(107, 76)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(520, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.minutos.Location = New System.Drawing.Point(590, 194)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(107, 76)
        Me.minutos.TabIndex = 2
        Me.minutos.Text = "00"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dias.Location = New System.Drawing.Point(467, 285)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(151, 54)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.fecha.Location = New System.Drawing.Point(387, 359)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(310, 35)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(393, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 224)
        Me.Panel1.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(392, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 224)
        Me.Panel2.TabIndex = 9
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(177, 162)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(95, 28)
        Me.reset.TabIndex = 4
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(16, 162)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(82, 28)
        Me.start.TabIndex = 3
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(57, 54)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(196, 39)
        Me.tiempo.TabIndex = 2
        Me.tiempo.Text = "00:00:00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cronometro"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Location = New System.Drawing.Point(593, 164)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(39, 13)
        Me.segundos.TabIndex = 8
        Me.segundos.Text = "Label3"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Practica_4.My.Resources.Resources.hourglass__v1
        Me.PictureBox3.Location = New System.Drawing.Point(444, 424)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Practica_4.My.Resources.Resources.jk
        Me.PictureBox2.Location = New System.Drawing.Point(533, 424)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Config
        '
        Me.Config.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Config.Image = Global.Practica_4.My.Resources.Resources.descarga1
        Me.Config.Location = New System.Drawing.Point(622, 424)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(70, 62)
        Me.Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Config.TabIndex = 6
        Me.Config.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica_4.My.Resources.Resources.reloj
        Me.PictureBox1.Location = New System.Drawing.Point(-35, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1152, 864)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 224)
        Me.Panel3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 752)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Config)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Config, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents minutos As Label
    Friend WithEvents dias As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Config As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reset As Button
    Friend WithEvents start As Button
    Friend WithEvents tiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
