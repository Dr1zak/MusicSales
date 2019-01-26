<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbArtist = New System.Windows.Forms.ComboBox()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblSQL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCompany2 = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnInsert2 = New System.Windows.Forms.Button()
        Me.btnRetrieve2 = New System.Windows.Forms.Button()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.OracleSelectCommand1 = New System.Data.OracleClient.OracleCommand()
        Me.OracleConnection1 = New System.Data.OracleClient.OracleConnection()
        Me.OracleInsertCommand1 = New System.Data.OracleClient.OracleCommand()
        Me.OracleUpdateCommand1 = New System.Data.OracleClient.OracleCommand()
        Me.OracleDeleteCommand1 = New System.Data.OracleClient.OracleCommand()
        Me.OracleDataAdapter1 = New System.Data.OracleClient.OracleDataAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Company"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(507, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sales (in Millions)"
        '
        'cmbArtist
        '
        Me.cmbArtist.FormattingEnabled = True
        Me.cmbArtist.Location = New System.Drawing.Point(16, 192)
        Me.cmbArtist.Name = "cmbArtist"
        Me.cmbArtist.Size = New System.Drawing.Size(202, 21)
        Me.cmbArtist.TabIndex = 4
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(244, 192)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(205, 21)
        Me.cmbCompany.TabIndex = 5
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(486, 192)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(210, 20)
        Me.txtSales.TabIndex = 6
        '
        'lblSQL
        '
        Me.lblSQL.AutoSize = True
        Me.lblSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSQL.Location = New System.Drawing.Point(399, 268)
        Me.lblSQL.Name = "lblSQL"
        Me.lblSQL.Size = New System.Drawing.Size(50, 24)
        Me.lblSQL.TabIndex = 7
        Me.lblSQL.Text = "SQL"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(428, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 36)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Retrieve"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 506)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1317, 561)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 58)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1033, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Company"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(844, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Company"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1288, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Country"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1046, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Location"
        '
        'cmbCompany2
        '
        Me.cmbCompany2.FormattingEnabled = True
        Me.cmbCompany2.Location = New System.Drawing.Point(806, 191)
        Me.cmbCompany2.Name = "cmbCompany2"
        Me.cmbCompany2.Size = New System.Drawing.Size(165, 21)
        Me.cmbCompany2.TabIndex = 18
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(1011, 191)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(161, 20)
        Me.txtLocation.TabIndex = 19
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(1219, 191)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(210, 20)
        Me.txtCountry.TabIndex = 20
        '
        'btnClear2
        '
        Me.btnClear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear2.Location = New System.Drawing.Point(1273, 340)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(97, 36)
        Me.btnClear2.TabIndex = 21
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnInsert2
        '
        Me.btnInsert2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert2.Location = New System.Drawing.Point(806, 380)
        Me.btnInsert2.Name = "btnInsert2"
        Me.btnInsert2.Size = New System.Drawing.Size(116, 36)
        Me.btnInsert2.TabIndex = 22
        Me.btnInsert2.Text = " Insert"
        Me.btnInsert2.UseVisualStyleBackColor = True
        '
        'btnRetrieve2
        '
        Me.btnRetrieve2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieve2.Location = New System.Drawing.Point(806, 422)
        Me.btnRetrieve2.Name = "btnRetrieve2"
        Me.btnRetrieve2.Size = New System.Drawing.Size(116, 36)
        Me.btnRetrieve2.TabIndex = 23
        Me.btnRetrieve2.Text = "Retrieve"
        Me.btnRetrieve2.UseVisualStyleBackColor = True
        '
        'btnUpdate2
        '
        Me.btnUpdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.Location = New System.Drawing.Point(806, 464)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(116, 36)
        Me.btnUpdate2.TabIndex = 24
        Me.btnUpdate2.Text = "Update"
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete2.Location = New System.Drawing.Point(806, 506)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(116, 36)
        Me.btnDelete2.TabIndex = 25
        Me.btnDelete2.Text = "Delete"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'OracleSelectCommand1
        '
        Me.OracleSelectCommand1.CommandText = "SELECT        ARTIST.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            ARTIST"
        Me.OracleSelectCommand1.Connection = Me.OracleConnection1
        '
        'OracleConnection1
        '
        Me.OracleConnection1.ConnectionString = "Data Source=mf057pc16/orcl.pmu.edu.sa;Persist Security Info=True;User ID=u2012021" & _
    "87;Password=alturki26370726;Unicode=True"
        '
        'OracleInsertCommand1
        '
        Me.OracleInsertCommand1.CommandText = "INSERT INTO ""ARTIST"" (""ARTIST"", ""COMPANY"", ""SALES"") VALUES (:ARTIST, :COMPANY, :S" & _
    "ALES)"
        Me.OracleInsertCommand1.Connection = Me.OracleConnection1
        Me.OracleInsertCommand1.Parameters.AddRange(New System.Data.OracleClient.OracleParameter() {New System.Data.OracleClient.OracleParameter("ARTIST", System.Data.OracleClient.OracleType.VarChar, 0, "ARTIST"), New System.Data.OracleClient.OracleParameter("COMPANY", System.Data.OracleClient.OracleType.VarChar, 0, "COMPANY"), New System.Data.OracleClient.OracleParameter("SALES", System.Data.OracleClient.OracleType.Number, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SALES", System.Data.DataRowVersion.Current, Nothing)})
        '
        'OracleUpdateCommand1
        '
        Me.OracleUpdateCommand1.CommandText = resources.GetString("OracleUpdateCommand1.CommandText")
        Me.OracleUpdateCommand1.Connection = Me.OracleConnection1
        Me.OracleUpdateCommand1.Parameters.AddRange(New System.Data.OracleClient.OracleParameter() {New System.Data.OracleClient.OracleParameter("ARTIST", System.Data.OracleClient.OracleType.VarChar, 0, "ARTIST"), New System.Data.OracleClient.OracleParameter("COMPANY", System.Data.OracleClient.OracleType.VarChar, 0, "COMPANY"), New System.Data.OracleClient.OracleParameter("SALES", System.Data.OracleClient.OracleType.Number, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SALES", System.Data.DataRowVersion.Current, Nothing), New System.Data.OracleClient.OracleParameter("Original_ARTIST", System.Data.OracleClient.OracleType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ARTIST", System.Data.DataRowVersion.Original, Nothing), New System.Data.OracleClient.OracleParameter("IsNull_COMPANY", System.Data.OracleClient.OracleType.Int32, 0, System.Data.ParameterDirection.Input, "COMPANY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OracleClient.OracleParameter("Original_COMPANY", System.Data.OracleClient.OracleType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPANY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OracleClient.OracleParameter("IsNull_SALES", System.Data.OracleClient.OracleType.Int32, 0, System.Data.ParameterDirection.Input, "SALES", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OracleClient.OracleParameter("Original_SALES", System.Data.OracleClient.OracleType.Number, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SALES", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OracleDeleteCommand1
        '
        Me.OracleDeleteCommand1.CommandText = resources.GetString("OracleDeleteCommand1.CommandText")
        Me.OracleDeleteCommand1.Connection = Me.OracleConnection1
        Me.OracleDeleteCommand1.Parameters.AddRange(New System.Data.OracleClient.OracleParameter() {New System.Data.OracleClient.OracleParameter("Original_ARTIST", System.Data.OracleClient.OracleType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ARTIST", System.Data.DataRowVersion.Original, Nothing), New System.Data.OracleClient.OracleParameter("IsNull_COMPANY", System.Data.OracleClient.OracleType.Int32, 0, System.Data.ParameterDirection.Input, "COMPANY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OracleClient.OracleParameter("Original_COMPANY", System.Data.OracleClient.OracleType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPANY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OracleClient.OracleParameter("IsNull_SALES", System.Data.OracleClient.OracleType.Int32, 0, System.Data.ParameterDirection.Input, "SALES", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OracleClient.OracleParameter("Original_SALES", System.Data.OracleClient.OracleType.Number, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SALES", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OracleDataAdapter1
        '
        Me.OracleDataAdapter1.DeleteCommand = Me.OracleDeleteCommand1
        Me.OracleDataAdapter1.InsertCommand = Me.OracleInsertCommand1
        Me.OracleDataAdapter1.SelectCommand = Me.OracleSelectCommand1
        Me.OracleDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ARTIST", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ARTIST", "ARTIST"), New System.Data.Common.DataColumnMapping("COMPANY", "COMPANY"), New System.Data.Common.DataColumnMapping("SALES", "SALES")})})
        Me.OracleDataAdapter1.UpdateCommand = Me.OracleUpdateCommand1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1480, 645)
        Me.Controls.Add(Me.btnDelete2)
        Me.Controls.Add(Me.btnUpdate2)
        Me.Controls.Add(Me.btnRetrieve2)
        Me.Controls.Add(Me.btnInsert2)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.cmbCompany2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSQL)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.cmbArtist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Music Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbArtist As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents lblSQL As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCompany2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents btnInsert2 As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve2 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents OracleSelectCommand1 As System.Data.OracleClient.OracleCommand
    Friend WithEvents OracleConnection1 As System.Data.OracleClient.OracleConnection
    Friend WithEvents OracleInsertCommand1 As System.Data.OracleClient.OracleCommand
    Friend WithEvents OracleUpdateCommand1 As System.Data.OracleClient.OracleCommand
    Friend WithEvents OracleDeleteCommand1 As System.Data.OracleClient.OracleCommand
    Friend WithEvents OracleDataAdapter1 As System.Data.OracleClient.OracleDataAdapter

End Class
