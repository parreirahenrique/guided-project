# Especificação do projeto
O projeto de código Starter deste módulo inclui um arquivo Program.cs com os seguintes recursos de código:

- O código declara variáveis que são usadas para coletar e processar dados de animais de estimação e seleções de itens de menu

- O código declara a matriz ourAnimals que inclui as seguintes informações sobre cada animal na matriz:

    - Número de ID do animal de estimação.
    - Espécie do animal de estimação (gato ou cachorro).
    - Idade do animal de estimação (em anos).
    - Uma descrição da aparência física do animal de estimação.
    - Uma descrição da personalidade do animal de estimação.
    - O apelido do animal de estimação.

- O código usa um loop for ao redor de um constructo switch-case para preencher os elementos da matriz ourAnimals.

    - O código inclui um loop ao redor de um menu principal que termina quando o usuário digita "sair". O menu principal inclui o seguinte:

        1. Listar todas as informações atuais sobre animais de estimação.
        2. Atribuir valores aos campos da matriz ourAnimals.
        3. Verificar se os dados de idade e descrição física dos animais estão completos.
        4. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.
        5. Editar a idade do animal.
        6. Editar a descrição de personalidade do animal.
        7. Exibir todos os gatos com uma característica especificada.
        8. Exibir todos os cães com uma característica especificada.
    
        Entre na seleção de item de menu ou digite "Sair" para sair do programa

- O código lê a seleção do item de menu feita pelo usuário e usa uma instrução switch para fazer branching do código para cada número de item de menu.

- O código inclui a implementação para as opções de menu 1 e 2.

- O código exibe uma mensagem "em construção" para as opções de menu de 3 a 8.

Seu objetivo neste desafio é criar os recursos do aplicativo em alinhamento com as opções de menu 3 e 4.

> Observação:
> 
> Quando novos animais chegam, eles devem ser adicionados à matriz ourAnimals. No entanto, a idade de um animal e algumas características físicas de um animal de estimação podem ser desconhecidas antes do exame de um veterinário. Além disso, o apelido e a personalidade de um animal podem ser desconhecidos quando ele chega. Os novos recursos que você está desenvolvendo garantirão a existência de um conjunto de dados completo para cada animal na matriz ourAnimals.

Para garantir que as idades dos animais e as descrições físicas estejam completas, o código deve fazer o seguinte:

- Atribuir um valor numérico válido a petAge para qualquer animal que tenha dados atribuídos na matriz ourAnimals, mas não tenha uma idade atribuída.
- Atribuir uma cadeia de caracteres válida a petPhysicalDescription para qualquer animal que tenha dados atribuídos na matriz ourAnimals, mas não tenha recebido uma descrição física.
- Verificar se as descrições físicas têm um valor atribuído. Os valores atribuídos não podem ter zero caracteres. Qualquer outro requisito depende de você.

Para garantir que os apelidos dos animais e suas descrições de personalidade estejam preenchidos, o código deve fazer o seguinte:

- Atribuir uma cadeia de caracteres válida a petNickname para qualquer animal que tenha dados atribuídos na matriz ourAnimals, mas não tenha um apelido atribuído.
- Atribuir uma cadeia de caracteres válida a petPersonalityDescription para qualquer animal que tenha dados atribuídos na matriz ourAnimals, mas não tenha uma descrição de personalidade atribuída.
- Verificar se apelidos e descrições de personalidade têm um valor atribuído. Os valores atribuídos não podem ter zero caracteres. Qualquer outro requisito depende de você.