 Private Sub Birinci()
        satir = BunifuCustomDataGrid1.Rows.Count
        nn = satir - 1
        kk = nn - 1
    End Sub
    Private Sub Second()
        j = kk + 1
        Third()

    End Sub
    Private Sub Third()
        satir = BunifuCustomDataGrid1.Rows.Count

        pp(j) = pp(j) + pp(j - (kk))
        pp(j - (kk)) = pp(j) - pp(j - (kk))
        pp(j) = pp(j) - pp(j - (kk))
        noo(j) = noo(j) + noo(j - (kk))
        noo(j - (kk)) = noo(j) - noo(j - (kk))
        noo(j) = noo(j) - noo(j - (kk))
        dd(j) = dd(j) + dd(j - (kk))
        dd(j - (kk)) = dd(j) - dd(j - (kk))
        dd(j) = dd(j) - dd(j - (kk))
        ll(j) = ll(j) + ll(j - (kk))
        ll(j - (kk)) = ll(j) - ll(j - (kk))
        ll(j) = ll(j) - ll(j - (kk))
        ee(j) = ee(j) + ee(j - (kk))
        ee(j - (kk)) = ee(j) - ee(j - (kk))
        ee(j) = ee(j) - ee(j - (kk))

        If (j - kk) <= 0 Then
            Sixth()
            Exit Sub
        End If
        If (j - kk) > 0 Then
            cc(satir - 1) = pp(satir - 1)

            For i = satir - 2 To 1 Step -1

                cc(i) = cc(i + 1) + pp(i)

            Next
            For i = 1 To satir - 1
                If (cc(i) - dd(i)) <= 0 Then
                    erken(i) = (dd(i) - cc(i)) * ee(i)
                    gecikme(i) = 0
                End If

                If (cc(i) - dd(i)) > 0 Then
                    gecikme(i) = (cc(i) - dd(i)) * ll(i)
                    erken(i) = 0
                End If
            Next
            For sayaç = satir - 1 To 1 Step -1

                bfsteps.DataGridView3.Rows.Add(noo(sayaç), pp(sayaç), dd(sayaç), cc(sayaç), gecikme(sayaç), erken(sayaç))

            Next
            yenicezaa = gecikme(0)


            For i = 1 To satir - 2
                yenicezaa = yenicezaa + gecikme(i)


            Next
            If yenicezaa > cezaa Then


                pp(j) = pp(j) + pp(j - (kk))
                pp(j - (kk)) = pp(j) - pp(j - (kk))
                pp(j) = pp(j) - pp(j - (kk))
                noo(j) = noo(j) + noo(j - (kk))
                noo(j - (kk)) = noo(j) - noo(j - (kk))
                noo(j) = noo(j) - noo(j - (kk))
                dd(j) = dd(j) + dd(j - (kk))
                dd(j - (kk)) = dd(j) - dd(j - (kk))
                dd(j) = dd(j) - dd(j - (kk))
                ll(j) = ll(j) + ll(j - (kk))
                ll(j - (kk)) = ll(j) - ll(j - (kk))
                ll(j) = ll(j) - ll(j - (kk))
                ee(j) = ee(j) + ee(j - (kk))
                ee(j - (kk)) = ee(j) - ee(j - (kk))
                ee(j) = ee(j) - ee(j - (kk))
                j = j + 1
                If j <= nn Then
                    Third()
                    Exit Sub
                End If
                If j > nn Then
                    Sixth()
                    Exit Sub
                End If
            End If
            If yenicezaa <= cezaa Then
                cezaa = yenicezaa
                Fifth()
                Exit Sub

            End If







        End If


    End Sub Private Sub Fifth()

        Birinci()
        j = j + 1
        If j <= nn Then
            Third()
            Exit Sub
        End If
        If j > nn Then
            Sixth()
            Exit Sub
        End If

    End Sub Private Sub Sixth()
        kk = kk - 1
        If kk > 0 Then
            Second()
            Exit Sub
        End If
        If kk = 0 Then
            Seventh()
            Exit Sub
        End If

    End Sub  Private Sub Seventh()
        cc(satir - 1) = pp(satir - 1)
        For i = satir - 2 To 1 Step -1

            cc(i) = cc(i + 1) + pp(i)

        Next

        For i = 1 To satir - 1
            If cc(i) - dd(i) <= 0 Then
                erken(i) = (dd(i) - cc(i)) * ee(i)
                gecikme(i) = 0
            End If
            If cc(i) - dd(i) > 0 Then
                gecikme(i) = (cc(i) - dd(i)) * ll(i)
                erken(i) = 0
            End If
        Next
        For sayaç = satir - 1 To 1 Step -1

            bfsteps.DataGridView3.Rows.Add(noo(sayaç), pp(sayaç), dd(sayaç), cc(sayaç), gecikme(sayaç), erken(sayaç))

        Next
        yenicezaa = gecikme(0)


        For i = 1 To satir - 2
            yenicezaa = yenicezaa + gecikme(i)


        Next


        bfsteps.Label3.Text = yenicezaa



    End Sub