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
            For saya� = dongu To satir - 2
                For saya�2 = saya� + 1 To satir - 1
                    If ceza(saya�2) < ceza(saya�) Then
                        geciciceza = ceza(saya�)
                        ceza(saya�) = ceza(saya�2)
                        ceza(saya�2) = geciciceza
                        gecici = pp(saya�)
                        gecici2 = noo(saya�)
                        gecici3 = dd(saya�)
                        gecici4 = ee(saya�)
                        gecici5 = ll(saya�)
                        gecici6 = cc(saya�)
                        cc(saya�) = cc(saya�2)
                        cc(saya�2) = gecici6
                        ll(saya�) = ll(saya�2)
                        ll(saya�2) = gecici5
                        ee(saya�) = ee(saya�2)
                        ee(saya�2) = gecici4
                        dd(saya�) = dd(saya�2)
                        dd(saya�2) = gecici3
                        noo(saya�) = noo(saya�2)
                        noo(saya�2) = gecici2
                        pp(saya�) = pp(saya�2)
                        pp(saya�2) = gecici


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





        For saya� = satir - 1 To 1 Step -1

            bfsteps.DataGridView2.Rows.Add(noo(saya�), pp(saya�), dd(saya�), cc(saya�))








        Next

        For i = 1 To satir - 1
            If cc(i) - dd(i) <= 0 Then bfsteps.DataGridView2.Rows(-i + (satir - 1)).Cells(5).Value = (dd(i) - cc(i)) * ee(i)
            If cc(i) - dd(i) > 0 Then bfsteps.DataGridView2.Rows(-i + (satir - 1)).Cells(4).Value = (cc(i) - dd(i)) * ll(i)
        Next
        cezaa = bfsteps.DataGridView2.Rows(0).Cells(4).Value

        For i = 1 To satir - 2
            cezaa = cezaa + bfsteps.DataGridView2.Rows(i - 1).Cells(4).Value

        Next