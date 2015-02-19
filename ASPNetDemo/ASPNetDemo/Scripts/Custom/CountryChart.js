     
            var appenddata;
            var list = "";
            var myarraypopulation = new Array();
            var myarrayYear = new Array();
            var arrayColor = [];
            bindJSONStates();
            $("#states").select2({ placeholder: "Select a State", allowClear: true,
                minimumInputLength: 0,
                maximumSelectionSize: 2,
                formatResult: format,
                formatSelection: format,
                escapeMarkup: function (m) { return m; }
            });

            function format(state) {
                if (!state.id) return state.text;
                return "<img height='20px' width='20px' src='Images/" + $.trim(state.id) + ".jpeg'/>" + "&nbsp;" + state.text;
            }

            $(document).on('change', "#states", function () {
                $('#chart3').empty();
                myarraypopulation = [];
                myarrayYear = [];
                arrayColor = [];
                var stateName = $("#states option:selected").text();              
                myarraypopulation = getPopulationByState(stateName);
                $.each(myarraypopulation, function (key, value) {
                    if (value >= 300000) {
                        arrayColor.push('red');
                    }
                    else {
                        arrayColor.push('blue');
                    }
                });

                myarrayYear = getYearByState(stateName);
                plotBarChart(myarraypopulation, myarrayYear, arrayColor);
            });


            function bindJSONStates() {
                var data;         
                $.ajax({
                    url: 'BarChart.json',
                    async: false,
                    success: function (data) {
                        data = JSON.parse(data);
                        $.each(data, function (key, value) {
                            $.each(value, function (k, v) {
                                if (v.State != list) {
                                    appenddata += "<option value = '" + v.State + " '>" + v.State + " </option>";
                                    list = v.State;
                                }
                            });
                        });
                        $('#states').html(appenddata);
                    },
                    error: function (data) {
                        alert("error timeout");
                    }
                });
            }

            function getYearByState(stateName) {
                myarrayYear.splice(0, myarrayYear.length);
                $.ajax({
                    url: 'BarChart.json',
                    async: false,
                    success: function (data) {
                        var data = JSON.parse(data);
                        $.each(data, function (key, value) {
                            $.each(value, function (k1, v1) {
                                var match = stateName.match(v1.State);
                                if (match) {
                                    myarrayYear.push(v1.Year);
                                }
                            });
                        });
                    },
                    error: function (data) {
                        alert("error timeout");
                    }
                });
                return myarrayYear;
            }

            function getPopulationByState(stateName) {
                myarraypopulation.splice(0, myarraypopulation.length);
                $.ajax({
                    url: 'BarChart.json',
                    async: false,
                    success: function (data) {
                        var data = JSON.parse(data);
                        $.each(data, function (key, value) {
                            $.each(value, function (k1, v1) {
                                var match = stateName.match(v1.State);
                                if (match) {
                                    myarraypopulation.push(v1.Population);
                                }
                            });
                        });
                    },
                    error: function (data) {
                        alert("error timeout");
                    }
                });
                return myarraypopulation;
            }

            function plotBarChart(s1, ticks, arrayColor) {

                var plot1 = $.jqplot('chart3', [s1], {                
                    seriesColors: arrayColor,
                    seriesDefaults: {
                        renderer: $.jqplot.BarRenderer,
                        pointLabels: { show: true, location: 'n', edgeTolerance: 0.2 },
                        rendererOptions: { fillToZero: true, varyBarColor: true }

                    },
                    axes: {
                        // Use a category axis on the x axis and use our custom ticks.
                        xaxis: {
                            renderer: $.jqplot.CategoryAxisRenderer,
                            ticks: ticks,
                            label: 'Year'
                        },
                        // Pad the y axis just a little so bars can get close to, but
                        // not touch, the grid boundaries.  1.2 is the default padding.
                        yaxis: {
                            pad: 1.2,
                            tickOptions: { formatString: '%d' },
                            label: 'Population',
                            max: 1500000,
                            min: 0

                        }
                    }

                });

                plotPieChart(ticks, s1);
            }

            function plotPieChart(year, population) {
                var data = [population];
                var plot1 = jQuery.jqplot('chart2', data,
            {
                seriesDefaults: {
                    // Make this a pie chart.
                    //color: 'white',
                    renderer: jQuery.jqplot.PieRenderer,
                    rendererOptions: {
                        // Turn off filling of slices.
                        fill: true,
                        showDataLabels: true,
                        // Add a margin to seperate the slices.
                        sliceMargin: 1,
                        // stroke the slices with a little thicker line.
                        lineWidth: 2
                    }
                },
                legend: {
                    show: true,
                    location: 'e',
                    labels: year,
                    showSwatch: true

                }
            }
              );
            }