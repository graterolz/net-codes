Public Class Form12
    'Este es para crear el arreglo de Pilas
    Dim A() As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'A es el arreglo donde se va a ir guardando todos los elementos de la cola,
        'se inicia en cero
        ReDim A(0)
    End Sub

    Function ColaPush(ByVal a() As Integer, ByVal elemento As Integer) As Integer()
        'Aqui lo que hace es obtener el espacio para el siguiente elemento del arreglo
        ReDim Preserve a(UBound(a) + 1)
        'Reemplaza el elemento en el espacio obtenido anteriormente
        a(UBound(a)) = elemento
        'Regresa el arreglo con el nuevo elemento
        Return a
    End Function

    'Ahora agregamos una función donde se va a ir actualizando el ListBox que se puso,
    'de cada movimiento que se haga
    Function ActualizaListBox(lst As ListBox)
        Dim p As Integer
        lst.Items.Clear()
        For p = 1 To UBound(A)
            'Se le va agregando cada elemento
            lst.Items.Add(A(p))
        Next
        Return True
    End Function

    Function ColaPop(ByRef a() As Integer)
        'Se declara una variable "i" donde se va a almacenar el elemento a sacar
        Dim i As Integer
        i = a(UBound(a) - UBound(a) + 1)
        'Aquí se corren los elementos, para poder borrar el primero 
        For j = 0 To a(UBound(a) - 1)
            a(j) = a(j + 1)
        Next j
        'Aquí se borra del arreglo el ultimo elemento
        ReDim Preserve a(UBound(a) - 1)
        'Regresa el elemento sacado
        Return i
    End Function

    'Esta función sirve para limpiar el arreglo de Pila e iniciarla en 0
    Function ColaClear(ByRef a() As Integer) As Integer()
        'Establece el arreglo a cero
        ReDim a(0)
        'Esto es para que regrese la función el arreglo en cero.
        Return a
    End Function

    'Esta función es para saber cuantos elementos hay en la Cola
    Function ColaCount(ByVal a() As Integer) As Integer
        'Obtiene el número de elementos en el arreglo de Cola.
        Return (UBound(a))
    End Function

    'Esta función es para saber cual es el siguiente elemento a sacar de la Cola
    Function ColaPeek(ByVal a() As Integer) As Integer
        'Obtiene el último elemento de la Cola
        Return a(UBound(a) - UBound(a) + 1)
    End Function

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim n As Integer
        n = CInt(txtN.Text)
        A = ColaPush(A, n)
        'Se llama a la función para actualizar el ListBox
        ActualizaListBox(lstElementos)
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        'Mensaje donde se conocerá el elemento sacado de la pila
        MsgBox("Elemento que se ha sacado de la pila: " & ColaPop(A))
        'Se llama a la función para actualizar el ListBox
        ActualizaListBox(lstElementos)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ColaClear(A)
        ActualizaListBox(lstElementos)
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        'Mensaje donde se conocerá el número de elementos en la Cola
        MsgBox("Elementos en la Pila: " & ColaCount(A))
    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        'Mensaje donde se concoerá el elemento a sacar de la Cola
        MsgBox("Próximo elemento a sacar de la pila: " & ColaPeek(A))
    End Sub
End Class