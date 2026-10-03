Module SessionManager
    Public IsAuthenticated As Boolean = False
    Public CurrentUser As String = ""
    Public Users As New System.Collections.Generic.Dictionary(Of String, String)()

    Public Function Register(username As String, password As String, ByRef message As String) As Boolean
        If String.IsNullOrWhiteSpace(username) Then
            message = "Username is required."
            Return False
        End If
        If String.IsNullOrWhiteSpace(password) Then
            message = "Password is required."
            Return False
        End If
        If Users.ContainsKey(username) Then
            message = "Username already exists."
            Return False
        End If
        Users.Add(username, password)
        message = "Account created successfully."
        Return True
    End Function

    Public Function Validate(username As String, password As String, ByRef message As String) As Boolean
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            message = "Please provide username and password."
            Return False
        End If
        Dim stored As String = Nothing
        If Users.TryGetValue(username, stored) Then
            If stored = password Then
                IsAuthenticated = True
                CurrentUser = username
                message = "Login successful."
                Return True
            Else
                message = "Invalid password."
                Return False
            End If
        Else
            message = "Username not found. Please create an account first."
            Return False
        End If
    End Function

    Public Sub Logout()
        IsAuthenticated = False
        CurrentUser = ""
    End Sub
End Module
