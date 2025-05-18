# FECAP - Fundação de Comércio Álvares Penteado

<p align="center">
<a href= "https://www.fecap.br/"><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhZPrRa89Kma0ZZogxm0pi-tCn_TLKeHGVxywp-LXAFGR3B1DPouAJYHgKZGV0XTEf4AE&usqp=CAU" alt="FECAP - Fundação de Comércio Álvares Penteado" border="0"></a>
</p>

## Integrantes:

<a href="https://www.linkedin.com/in/henrique-jorge-2b977726b/" target="_blank">Henrique Jorge</a>, 
<a href="https://www.linkedin.com/in/pedro-augusto-da-silva-macedo-9a0200187/" target="_blank">Pedro Macedo</a>, 
<a href="https://www.linkedin.com/in/luiz-eduardo-souza-rocha-09aab2321/" target="_blank">Luiz Rocha</a>

# Instituto Criativo - Plataforma de Gestão de Eventos

![Preview da Página Inicial](public/images/preview.jpg)

## Descrição do Projeto

O Instituto Criativo é uma plataforma web completa para gestão de eventos educacionais, desenvolvida para uma ONG que transforma vidas através da educação criativa e inovadora. O sistema inclui:

- Página institucional com informações sobre a organização
- Área logada para administração de eventos
- Sistema completo de CRUD para eventos
- Páginas de autenticação (login e cadastro)

## Funcionalidades

### Páginas Públicas
- **Página Inicial**: Apresenta a missão, visão, valores e programas da ONG
- **Seção de Impacto**: Mostra estatísticas e depoimentos sobre o trabalho realizado
- **Área de Doações**: Permite que visitantes contribuam financeiramente
- **Formulário de Contato**: Para interessados em obter mais informações

### Área Logada
- **Dashboard**: Visão geral com métricas e próximos eventos
- **Criação de Eventos**: Formulário completo com:
  - Informações básicas do evento
  - Data e horário
  - Lista de participantes
  - Upload de imagem de divulgação
- **Edição de Eventos**: Fluxo em duas etapas para seleção e edição
- **Exclusão de Eventos**: Processo em três etapas com confirmação

## Tecnologias Utilizadas

- HTML5 semântico
- CSS3 moderno com Flexbox e Grid
- JavaScript (ES6+) para interatividade
- Design responsivo para todos os dispositivos
- Ícones do Font Awesome
- Fontes Google (Poppins, Roboto, Archivo)

## Estrutura de Arquivos
instituto-criativo/
├── public/ # Arquivos públicos
│ ├── images/ # Imagens do projeto
│ └── logo.png # Logo da organização
├── src/
│ ├── auth/ # Páginas de autenticação
│ │ ├── cadastro.html
│ │ ├── login.html
│ │ ├── styles.css # Estilos compartilhados
│ │ └── script.js # Lógica de autenticação
│ ├── dashboard/ # Área administrativa
│ │ ├── criar-evento.html
│ │ ├── editar-evento.html
│ │ ├── excluir-evento.html
│ │ ├── dashboard.html
│ │ ├── styles/ # Estilos específicos
│ │ │ ├── criar-evento.css
│ │ │ ├── dashboard.css
│ │ │ ├── editar-evento.css
│ │ │ └── excluir-evento.css
│ │ └── scripts/ # Lógica do dashboard
│ │ ├── criar-evento.js
│ │ ├── dashboard.js
│ │ ├── editar-evento.js
│ │ └── excluir-evento.js
│ └── pagina_inicial.html # Landing page institucional
├── README.md # Este arquivo
└── index.html # Ponto de entrada (redireciona para página inicial)

## Como Executar o Projeto

Siga estes passos para testar a plataforma localmente:

1. **Baixe e extraia os arquivos**
   - Faça o download do arquivo ZIP do projeto
   - Extraia os arquivos em uma pasta de sua preferência

2. **Acesse a página inicial**
   - Abra o arquivo `pagina_inicial.html` no seu navegador
   - Explore as seções institucionais (Sobre Nós, Programas, etc.)

3. **Acesse a área logada**
   - Clique no botão "Área logada" no menu superior
   - Você será redirecionado para a página de login

4. **Faça login (credenciais de teste)**
   
5. **Navegue pelo Dashboard**
- Visualize as estatísticas e eventos cadastrados
- Menu lateral permite acesso a todas funcionalidades

6. **Crie um novo evento**
- Clique em "Criar novo evento" no menu
- Preencha todos os campos obrigatórios (*)
- Adicione participantes clicando em "+ Adicionar"
- Selecione uma imagem para divulgação
- Clique em "Publicar" para salvar

7. **Edite um evento existente**
- No menu lateral, clique em "Editar evento"
- Selecione o evento na lista dropdown
- Modifique os campos desejados
- Clique em "Salvar Alterações"

8. **Exclua um evento**
- No menu, selecione "Excluir evento"
- Escolha o evento a ser removido
- Informe o motivo do cancelamento
- Confirme a exclusão marcando a caixa
- Clique em "Publicar Exclusão"

Dica: Todos os formulários possuem validação - campos com * são obrigatórios!

