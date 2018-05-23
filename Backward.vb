satir = BunifuCustomDataGrid1.Rows.Count
        Pi_toplam = BunifuCustomDataGrid1.Rows(0).Cells(1).Value
        pp(1) = BunifuCustomDataGrid1.Rows(0).Cells(1).Value
        cc(1) = pp(1)
        For i = 1 To satir - 1
            noo(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(0).Value
            pp(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(1).Value
            dd(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(2).Value
            ll(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(3).Value
            ee(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(4).Value

        Next i
        For i = 2 To satir - 1
            pp(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(1).Value
            cc(i) = cc(i - 1) + pp(i)

        Next
        For i = 2 To satir - 1

            pp(i) = BunifuCustomDataGrid1.Rows(i - 1).Cells(1).Value

            Pi_toplam = Pi_toplam + pp(i)
            tt = Pi_toplam
        Next i
        For i = 1 To satir - 1
            ceza(i) = (Math.Abs(tt - dd(i))) * ll(i)
        Next
        For dongu = 1 To satir - 1
            For sayaç = dongu To satir - 2
                For sayaç2 = sayaç + 1 To satir - 1
                    If ceza(sayaç2) < ceza(sayaç) Then
                        geciciceza = ceza(sayaç)
                        ceza(sayaç) = ceza(sayaç2)
                        ceza(sayaç2) = geciciceza
                        gecici = pp(sayaç)
                        gecici2 = noo(sayaç)
                        gecici3 = dd(sayaç)
                        gecici4 = ee(sayaç)
                        gecici5 = ll(sayaç)
                        gecici6 = cc(sayaç)
                        cc(sayaç) = cc(sayaç2)
                        cc(sayaç2) = gecici6
                        ll(sayaç) = ll(sayaç2)
                        ll(sayaç2) = gecici5
                        ee(sayaç) = ee(sayaç2)
                        ee(sayaç2) = gecici4
                        dd(sayaç) = dd(sayaç2)
                        dd(sayaç2) = gecici3
                        noo(sayaç) = noo(sayaç2)
                        noo(sayaç2) = gecici2
                        pp(sayaç) = pp(sayaç2)
                        pp(sayaç2) = gecici


                    End If
                Next
            Next

            tt = tt - pp(dongu)
            For i = 2 To satir - 1
                ceza(i) = (Math.Abs(tt - dd(i))) * ll(i)
            Next
        Next

        cc(satir - 1) = pp(satir - 1)


        For i = satir - 2 To 1 Step -1

            cc(i) = cc(i + 1) + pp(i)

        Next





        For sayaç = satir - 1 To 1 Step -1

            bfsteps.DataGridView2.Rows.Add(noo(sayaç), pp(sayaç), dd(sayaç), cc(sayaç))








        Next

        For i = 1 To satir - 1
            If cc(i) - dd(i) <= 0 Then bfsteps.DataGridView2.Rows(-i + (satir - 1)).Cells(5).Value = (dd(i) - cc(i)) * ee(i)
            If cc(i) - dd(i) > 0 Then bfsteps.DataGridView2.Rows(-i + (satir - 1)).Cells(4).Value = (cc(i) - dd(i)) * ll(i)
        Next
        cezaa = bfsteps.DataGridView2.Rows(0).Cells(4).Value

        For i = 1 To satir - 2
            cezaa = cezaa + bfsteps.DataGridView2.Rows(i - 1).Cells(4).Value

        Next