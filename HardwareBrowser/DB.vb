Imports System.Data
Imports System.Data.SqlClient

Public Class DB

    ''' <summary>
    ''' Returns location information from the database.
    ''' </summary>
    ''' <param name="Description"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetLocation(ByVal Description As String) As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetLocation", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@Description", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = Description
        command.SelectCommand.Parameters.Add(param0)

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT

    End Function

    ''' <summary>
    ''' Returns manufacturer information form the database.
    ''' </summary>
    ''' <param name="CompanyName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetManufacturer(ByVal CompanyName As String) As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetManufacturer", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = CompanyName
        command.SelectCommand.Parameters.Add(param0)

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns model information from the database.
    ''' </summary>
    ''' <param name="ModelName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetModel(ByVal ModelName As String) As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetModel", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@ModelName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = ModelName
        command.SelectCommand.Parameters.Add(param0)

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns users information from the database.
    ''' </summary>
    ''' <param name="LoginName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetUser(ByVal LoginName As String) As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetUser", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@LoginName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = LoginName
        command.SelectCommand.Parameters.Add(param0)

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns hardware info from the database.
    ''' </summary>
    ''' <param name="SerialNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetHardware(ByVal SerialNumber As String) As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetHardware", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@SerialNumber", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = SerialNumber
        command.SelectCommand.Parameters.Add(param0)

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Inserts a new admin into the database.
    ''' </summary>
    ''' <param name="UserName"></param>
    ''' <param name="Password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertAdmin(ByVal UserName As String, ByVal Password As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertAdmin", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@UserName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = UserName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Password", SqlDbType.VarChar, 50)
        param1.Direction = ParameterDirection.Input
        param1.Value = Password
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param2.Direction = ParameterDirection.Output
        command.Parameters.Add(param2)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Inserts a new location into the database.
    ''' </summary>
    ''' <param name="Description"></param>
    ''' <param name="Notes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertLocation(ByVal Description As String, ByVal Notes As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertLocation", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@Description", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = Description
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Notes", SqlDbType.VarChar, 200)
        param1.Direction = ParameterDirection.Input
        param1.Value = Notes
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param2.Direction = ParameterDirection.Output
        command.Parameters.Add(param2)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Inserts a new manufacturer into the database.
    ''' </summary>
    ''' <param name="CompanyName"></param>
    ''' <param name="ReturnAddress"></param>
    ''' <param name="PhoneNum"></param>
    ''' <param name="ReturnInstructions"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertManufacturer(ByVal CompanyName As String, ByVal ReturnAddress As String, ByVal PhoneNum As String, ByVal ReturnInstructions As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertManufacturer", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = CompanyName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@ReturnAddress", SqlDbType.VarChar, 100)
        param1.Direction = ParameterDirection.Input
        param1.Value = ReturnAddress
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@PhoneNum", SqlDbType.VarChar, 50)
        param2.Direction = ParameterDirection.Input
        param2.Value = PhoneNum
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@ReturnInstructions", SqlDbType.VarChar, 500)
        param3.Direction = ParameterDirection.Input
        param3.Value = ReturnInstructions
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param4.Direction = ParameterDirection.Output
        command.Parameters.Add(param4)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Inserts a new model into the database.
    ''' </summary>
    ''' <param name="Manufacturer"></param>
    ''' <param name="Description"></param>
    ''' <param name="ModelName"></param>
    ''' <param name="PartNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertModel(ByVal Manufacturer As String, ByVal Description As String, ByVal ModelName As String, ByVal PartNumber As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertModel", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@Manufacturer", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = Manufacturer
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Description", SqlDbType.VarChar, 500)
        param1.Direction = ParameterDirection.Input
        param1.Value = Description
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@ModelName", SqlDbType.VarChar, 50)
        param2.Direction = ParameterDirection.Input
        param2.Value = ModelName
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@PartNumber", SqlDbType.VarChar, 50)
        param3.Direction = ParameterDirection.Input
        param3.Value = PartNumber
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param4.Direction = ParameterDirection.Output
        command.Parameters.Add(param4)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Inserts a new user into the database.
    ''' </summary>
    ''' <param name="FirstName"></param>
    ''' <param name="LastName"></param>
    ''' <param name="PhoneNumber"></param>
    ''' <param name="LoginName"></param>
    ''' <param name="Location"></param>
    ''' <param name="Purpose"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertUser(ByVal FirstName As String, ByVal LastName As String, ByVal PhoneNumber As String, ByVal LoginName As String, ByVal Location As String, ByVal Purpose As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertUser", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@FirstName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = FirstName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@LastName", SqlDbType.VarChar, 50)
        param1.Direction = ParameterDirection.Input
        param1.Value = LastName
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@PhoneNumber", SqlDbType.VarChar, 50)
        param2.Direction = ParameterDirection.Input
        param2.Value = PhoneNumber
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@LoginName", SqlDbType.VarChar, 50)
        param3.Direction = ParameterDirection.Input
        param3.Value = LoginName
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@Location", SqlDbType.VarChar, 50)
        param4.Direction = ParameterDirection.Input
        param4.Value = Location
        command.Parameters.Add(param4)

        Dim param5 As New SqlParameter("@Purpose", SqlDbType.VarChar, 50)
        param5.Direction = ParameterDirection.Input
        param5.Value = Purpose
        command.Parameters.Add(param5)

        Dim param6 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param6.Direction = ParameterDirection.Output
        command.Parameters.Add(param6)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Inserts a hardware and its lease info into the database.
    ''' </summary>
    ''' <param name="SerialNumber"></param>
    ''' <param name="User"></param>
    ''' <param name="Notes"></param>
    ''' <param name="Model"></param>
    ''' <param name="HasLease"></param>
    ''' <param name="AssetTag"></param>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <param name="ReplacedAsset"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InsertHardware(ByVal SerialNumber As String, ByVal User As String, ByVal Notes As String, ByVal Model As String, ByVal HasLease As Boolean, ByVal AssetTag As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal ReplacedAsset As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("InsertHardware", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@SerialNumber", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = SerialNumber
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@User", SqlDbType.VarChar, 50)
        param1.Direction = ParameterDirection.Input
        param1.Value = User
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@Notes", SqlDbType.VarChar, 500)
        param2.Direction = ParameterDirection.Input
        param2.Value = Notes
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@Model", SqlDbType.VarChar, 50)
        param3.Direction = ParameterDirection.Input
        param3.Value = Model
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@HasLease", SqlDbType.Bit, 1)
        param4.Direction = ParameterDirection.Input
        param4.Value = HasLease
        command.Parameters.Add(param4)

        Dim param5 As New SqlParameter("@AssetTag", SqlDbType.VarChar, 50)
        param5.Direction = ParameterDirection.Input
        param5.Value = AssetTag
        command.Parameters.Add(param5)

        Dim param6 As New SqlParameter("@StartDate", SqlDbType.DateTime, 8)
        param6.Direction = ParameterDirection.Input
        param6.Value = StartDate
        command.Parameters.Add(param6)

        Dim param7 As New SqlParameter("@EndDate", SqlDbType.DateTime, 8)
        param7.Direction = ParameterDirection.Input
        param7.Value = EndDate
        command.Parameters.Add(param7)

        Dim param8 As New SqlParameter("@ReplacedAsset", SqlDbType.VarChar, 50)
        param8.Direction = ParameterDirection.Input
        param8.Value = ReplacedAsset
        command.Parameters.Add(param8)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Validates an admin login attempt.
    ''' </summary>
    ''' <param name="UserName"></param>
    ''' <param name="Password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ValidateAdmin(ByVal UserName As String, ByVal Password As String) As Integer
        Try
            Dim connection As New SqlConnection(My.Resources.ConnectionString)
            Dim command As New SqlDataAdapter("ValidateAdmin", connection)
            command.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim param0 As New SqlParameter("@UserName", SqlDbType.VarChar, 50)
            param0.Direction = ParameterDirection.Input
            param0.Value = UserName
            command.SelectCommand.Parameters.Add(param0)

            Dim param1 As New SqlParameter("@Password", SqlDbType.VarChar, 50)
            param1.Direction = ParameterDirection.Input
            param1.Value = Password
            command.SelectCommand.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@Success", SqlDbType.Int, 4)
            param2.Direction = ParameterDirection.Output
            command.SelectCommand.Parameters.Add(param2)

            Dim dtTemp As New DataTable
            connection.Open()
            command.Fill(dtTemp)
            connection.Close()

            Return CInt(command.SelectCommand.Parameters("@Success").Value)
        Catch ex As Exception
            MessageBox.Show("An error occured accessing the database. " & Err.Description, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ''' <summary>
    ''' Deletes an admin from the database.
    ''' </summary>
    ''' <param name="UserName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteAdmin(ByVal UserName As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteAdmin", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@UserName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = UserName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Returns all the admin usernames.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAdmins() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAdmins", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable()
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns all the manufacturer names.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAllManufacturerNames() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAllManufactuerNames", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable()
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns all the model names.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAllModelNames() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAllModelNames", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns all location names.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAllLocationNames() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAllLocationNames", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns all user names.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAllUsers() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAllUsers", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Returns all purposes.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAllPurpose() As DataTable
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlDataAdapter("GetAllPurpose", connection)
        command.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tmpDT As New DataTable
        command.Fill(tmpDT)

        Return tmpDT
    End Function

    ''' <summary>
    ''' Deletes a manufacturer from the database.
    ''' </summary>
    ''' <param name="CompanyName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteManufacturer(ByVal CompanyName As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteManufacturer", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = CompanyName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Deletes a model from the database.
    ''' </summary>
    ''' <param name="ModelName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteModel(ByVal ModelName As String)
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteModel", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@ModelName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = ModelName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Deletes a location from the database.
    ''' </summary>
    ''' <param name="Description"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteLocation(ByVal Description As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteLocation", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@Description", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = Description
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Deletes a user from the database.
    ''' </summary>
    ''' <param name="LoginName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteUser(ByVal LoginName As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteUser", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@LoginName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = LoginName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Deletes a hardware and its lease info from the database.
    ''' </summary>
    ''' <param name="SerialNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteHardware(ByVal SerialNumber As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("DeleteHardware", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@SerialNumber", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = SerialNumber
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param1.Direction = ParameterDirection.Output
        command.Parameters.Add(param1)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Updates a user in the database.
    ''' </summary>
    ''' <param name="FirstName"></param>
    ''' <param name="LastName"></param>
    ''' <param name="PhoneNumber"></param>
    ''' <param name="LoginName"></param>
    ''' <param name="Location"></param>
    ''' <param name="Purpose"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UpdateUser(ByVal FirstName As String, ByVal LastName As String, ByVal PhoneNumber As String, ByVal LoginName As String, ByVal Location As String, ByVal Purpose As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("UpdateUser", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@FirstName", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = FirstName
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@LastName", SqlDbType.VarChar, 50)
        param1.Direction = ParameterDirection.Input
        param1.Value = LastName
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@PhoneNumber", SqlDbType.VarChar, 50)
        param2.Direction = ParameterDirection.Input
        param2.Value = PhoneNumber
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@LoginName", SqlDbType.VarChar, 50)
        param3.Direction = ParameterDirection.Input
        param3.Value = LoginName
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@Location", SqlDbType.VarChar, 50)
        param4.Direction = ParameterDirection.Input
        param4.Value = Location
        command.Parameters.Add(param4)

        Dim param5 As New SqlParameter("@Purpose", SqlDbType.VarChar, 50)
        param5.Direction = ParameterDirection.Input
        param5.Value = Purpose
        command.Parameters.Add(param5)

        Dim param6 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param6.Direction = ParameterDirection.Output
        command.Parameters.Add(param6)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

    ''' <summary>
    ''' Updates a hardware in the database.
    ''' </summary>
    ''' <param name="SerialNumber"></param>
    ''' <param name="User"></param>
    ''' <param name="Notes"></param>
    ''' <param name="Model"></param>
    ''' <param name="HasLease"></param>
    ''' <param name="AssetTag"></param>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <param name="ReplacedAsset"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UpdateHardware(ByVal SerialNumber As String, ByVal User As String, ByVal Notes As String, ByVal Model As String, ByVal HasLease As Boolean, ByVal AssetTag As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal ReplacedAsset As String) As Integer
        Dim connection As New SqlConnection(My.Resources.ConnectionString)
        Dim command As New SqlCommand("UpdateHardware", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim param0 As New SqlParameter("@SerialNumber", SqlDbType.VarChar, 50)
        param0.Direction = ParameterDirection.Input
        param0.Value = SerialNumber
        command.Parameters.Add(param0)

        Dim param1 As New SqlParameter("@User", SqlDbType.VarChar, 50)
        param1.Direction = ParameterDirection.Input
        param1.Value = User
        command.Parameters.Add(param1)

        Dim param2 As New SqlParameter("@Notes", SqlDbType.VarChar, 500)
        param2.Direction = ParameterDirection.Input
        param2.Value = Notes
        command.Parameters.Add(param2)

        Dim param3 As New SqlParameter("@Model", SqlDbType.VarChar, 50)
        param3.Direction = ParameterDirection.Input
        param3.Value = Model
        command.Parameters.Add(param3)

        Dim param4 As New SqlParameter("@HasLease", SqlDbType.Bit, 1)
        param4.Direction = ParameterDirection.Input
        param4.Value = HasLease
        command.Parameters.Add(param4)

        Dim param5 As New SqlParameter("@AssetTag", SqlDbType.VarChar, 50)
        param5.Direction = ParameterDirection.Input
        param5.Value = AssetTag
        command.Parameters.Add(param5)

        Dim param6 As New SqlParameter("@StartDate", SqlDbType.DateTime, 8)
        param6.Direction = ParameterDirection.Input
        param6.Value = StartDate
        command.Parameters.Add(param6)

        Dim param7 As New SqlParameter("@EndDate", SqlDbType.DateTime, 8)
        param7.Direction = ParameterDirection.Input
        param7.Value = EndDate
        command.Parameters.Add(param7)

        Dim param8 As New SqlParameter("@ReplacedAsset", SqlDbType.VarChar, 50)
        param8.Direction = ParameterDirection.Input
        param8.Value = ReplacedAsset
        command.Parameters.Add(param8)

        Dim param9 As New SqlParameter("@Success", SqlDbType.Int, 4)
        param9.Direction = ParameterDirection.Output
        command.Parameters.Add(param9)

        connection.Open()
        Dim numRowsAffected As Integer = CInt(command.ExecuteNonQuery())
        connection.Close()

        Return numRowsAffected
    End Function

End Class
