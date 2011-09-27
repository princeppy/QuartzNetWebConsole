﻿Imports System.Runtime.CompilerServices

Public Module EnumerableExtensions
    <Extension()> _
    Public Function WhereOdd(Of T)(ByVal s As IEnumerable(Of T)) As IEnumerable(Of T)
        Return s.Select(Function(e, i) New With {.e = e, .i = i}).
            Where(Function(e) e.i Mod 2 <> 0).
            Select(Function(e) e.e)
    End Function

    <Extension()> _
    Public Function WhereEven(Of T)(ByVal s As IEnumerable(Of T)) As IEnumerable(Of T)
        Return s.Select(Function(e, i) New With {.e = e, .i = i}).
            Where(Function(e) e.i Mod 2 = 0).
            Select(Function(e) e.e)
    End Function
End Module