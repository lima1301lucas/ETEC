 function mostra_pass() {
     var senha = $('#pass');
     var olho = $("#olho");

     olho.mousedown(function () {
         senha.attr("type", "text");
     });

     olho.mouseup(function () {
         senha.attr("type", "password");
     });

     $("#olho").mouseout(function () {
         $("#senha").attr("type", "password");
     });

     var confsenha = $('#con-pass');
     var conolho = $("#con-olho");

     conolho.mousedown(function () {
         confsenha.attr("type", "text");
     });

     conolho.mouseup(function () {
         confsenha.attr("type", "password");
     });

     $("#olho").mouseout(function () {
         $("#senha").attr("type", "password");
     });
 }