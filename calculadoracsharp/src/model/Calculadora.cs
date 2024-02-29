public class Calculadora {

  public int calcular(String operacao, int a, int b){
    
    if (operacao=="1"){
      Soma op = new Soma();
      return op.calcular(a, b);
    }
    if (operacao=="2"){
      Subtracao op = new Subtracao();
      return op.calcular(a, b);
    }
    if (operacao=="3"){
      Multiplicacao op = new Multiplicacao();
      return op.calcular(a, b);
    }
    if (operacao=="4"){
      Divisao op = new Divisao();
      return op.calcular(a, b);
    }
    if (operacao=="5"){
      Potencia op = new Potencia();
      return op.calcular(a, b);
    }
    return 0;
  }

}

