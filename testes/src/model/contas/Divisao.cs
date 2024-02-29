public class Divisao {
    
    public int calcular(int a, int b){
        if (b == 0){ throw new DivideByZeroException("Não é possível dividir por zero."); }
        int resultado=a/b;

        return resultado;
    }
}