$(document).ready(function () {
    $("#send").click(function () {
        var data = {
            fechaIni: $("#fechaIncio").val(),
            fechaFin: $("#FechaFin").val()
        }
        debugger
    });

    var table = $('#example').DataTable();

    table.rows.add(
        {
            "data": [
                {
                    "ConnectionDeviceId": "Inv01",
                    "EventProcessedUtcTime": "2021-01-06T17:45:45.9900000Z",
                    "HEFESTO_ID": "49176RET1",
                    "timestamp": "2021-01-06 17:45:45.000000+00:00",
                    "var_name": "CVM_C5_9__1__POTENCIA ACTIVA AC",
                    "value": 1360,
                    "plugin": "MODBUS RTU/SERIAL",
                    "request": "CVM_C5_9",
                    "var_name_1": "Potencia Activa AC",
                    "device": 1
                },
                {
                    "ConnectionDeviceId": "Inv01",
                    "EventProcessedUtcTime": "2021-01-06T17:56:46.8690000Z",
                    "HEFESTO_ID": "49176RET1",
                    "timestamp": "2021-01-06 17:56:46.000000+00:00",
                    "var_name": "CVM_C5_9__1__POTENCIA ACTIVA AC",
                    "value": 917,
                    "plugin": "MODBUS RTU/SERIAL",
                    "request": "CVM_C5_9",
                    "var_name_1": "Potencia Activa AC",
                    "device": 1
                }
            ]
        }).draw();
});