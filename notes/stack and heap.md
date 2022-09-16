# Memória

Tem dois locais essencialmente.

## Stack (Mais valiosa)

Quando um vetor de qualquer coisa é criado o seu espaço na stack é apenas a informação(endereço) de onde o grande volume de dados está guardado.

```cpp
0xfee0001 - &array[0]
0xfee0002 - &array[1]
```

⚠️ String são vetores de caracteres.

Outra situação é para classes, no qual um objeto na stack é apenas uma referência de acesso aos dados do objeto.

## Heap (Menos valiosa)

Aqui é aonde este conteúdo do array será armazenado em um bloco contíguo de memória.

Aqui também são guardados os conteúdos de um determinado objeto.
