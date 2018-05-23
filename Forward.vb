 Birinci()
        Second()



        For sayaç = satir - 1 To 1 Step -1

            bfform.bf.Rows.Add(noo(sayaç), pp(sayaç), dd(sayaç), cc(sayaç), gecikme(sayaç), erken(sayaç))

        Next
        yenicezaa = gecikme(1)


        For i = 2 To satir - 1
            yenicezaa = yenicezaa + gecikme(i)


        Next


        bfform.Label7.Text = yenicezaa
        bfform.Label2.Text = Pi_toplam
        gecikenis = 0
        agirliksizgecikme = 0
        For i = 1 To satir - 1

            If cc(i) - dd(i) > 0 Then agirliksizgecikme = agirliksizgecikme + (cc(i) - dd(i))
            If cc(i) - dd(i) > 0 Then gecikenis = gecikenis + 1
        Next
        bfform.Label10.Text = gecikenis
        bfform.Label9.Text = agirliksizgecikme

        series1bf.ValueScaleType = ScaleType.Numerical

        For sayaç = 1 To satir - 1





            series1bf.Points.Add(New SeriesPoint("BF", (cc(sayaç) - pp(sayaç)), cc(sayaç)))



        Next


        bfform.bfgant.Series.AddRange(New Series() {series1bf})
        myview2bf.Color = Color.Aqua
        myview2bf.ColorEach = True
        myview2bf.MaxValueMarkerVisibility = True


        series1bf.Label.BackColor = Color.Yellow
        series1bf.Label.LineVisibility = True
        series1bf.Label.TextColor = Color.Azure
        myview2bf.MaxValueMarkerVisibility = DefaultBoolean.True
        myview2bf.MaxValueMarker.Color = Color.GreenYellow
        myview2bf.MaxValueMarker.Kind = MarkerKind.Star
        myview2bf.MaxValueMarker.StarPointCount = 5
        myview2bf.MaxValueMarker.Size = 10

        myview2bf.MinValueMarkerVisibility = DefaultBoolean.True
        myview2bf.MinValueMarker.Color = Color.GreenYellow
        myview2bf.MinValueMarker.Kind = MarkerKind.Circle
        myview2bf.MinValueMarker.Size = 10

        myview2bf.BarWidth = 0.5

        bfform.bfgant.Titles.Add(New ChartTitle())
        bfform.bfgant.Titles(0).Text = "Gantt Þemasý"





        bfform.bfgant.Visible = True


        For i = 1 To satir - 1

            If cc(i) > dd(i) Then cezaligecikme(i) = ((cc(i) - dd(i)) * ll(i))
            If cc(i) < dd(i) Then cezaligecikme(i) = 0


        Next i
        For i = 1 To satir - 1

            gecikme(i) = cc(i) - dd(i)
            If gecikme(i) < 0 Then gecikme(i) = 0


        Next i
        agirliksizgecikme = 0
        For i = 1 To satir - 1

            If cc(i) - dd(i) > 0 Then agirliksizgecikme = agirliksizgecikme + gecikme(i)

        Next
        bfform.Label9.Text = agirliksizgecikme
        For sayaç = 1 To satir - 1




            series3bf.Points.Add(New SeriesPoint(noo(sayaç), gecikme(sayaç)))
        Next
        For sayaç = 1 To satir - 1



            series2bf.Points.Add(New SeriesPoint(noo(sayaç), cezaligecikme(sayaç)))

        Next
        bfform.bfgecikmepie.Series.AddRange(New Series() {series2bf})
        bfform.bfgecikmepie.Titles.Add(New ChartTitle())
        bfform.bfgecikmepie.Titles(0).Text = "Ceza Oranlarý"
        bfform.bfcezapie.Series.AddRange(New Series() {series3bf})
        bfform.bfcezapie.Titles.Add(New ChartTitle())
        bfform.bfcezapie.Titles(0).Text = "Gecikme Oranlarý"
        series2bf.Label.TextPattern = "{A}: {VP:p0}"
        CType(series2bf.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns
        CType(series2bf.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
        myview3bf.Titles.Add(New SeriesTitle())
        myview3bf.Titles(0).Text = series2bf.Name
        myview3bf.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9))
        myview3bf.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"))
        myview3bf.ExplodeMode = PieExplodeMode.UseFilters
        myview3bf.ExplodedDistancePercentage = 30

        CType(series3bf.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns
        CType(series3bf.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

        myview4bf.Titles.Add(New SeriesTitle())
        myview4bf.Titles(0).Text = series3bf.Name
        myview4bf.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9))
        myview4bf.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"))
        myview4bf.ExplodeMode = PieExplodeMode.UseFilters
        myview4bf.ExplodedDistancePercentage = 30