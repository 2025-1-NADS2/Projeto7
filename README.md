# Instituto Criativo - Plataforma de Gestão de Eventos

<p align="center">
  <a href="https://www.fecap.br/">
    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhZPrRa89Kma0ZZogxm0pi-tCn_TLKeHGVxywp-LXAFGR3B1DPouAJYHgKZGV0XTEf4AE&usqp=CAU" alt="FECAP - Fundação de Comércio Álvares Penteado">
  </a>
</p>

## 👥 Integrantes

- [Henrique Jorge](https://www.linkedin.com/in/henrique-jorge-2b977726b/)
- [Pedro Macedo](https://www.linkedin.com/in/pedro-augusto-da-silva-macedo-9a0200187/)
- [Luiz Rocha](https://www.linkedin.com/in/luiz-eduardo-souza-rocha-09aab2321/)

---

## 📝 Descrição do Projeto

O **Instituto Criativo** é uma plataforma web desenvolvida para uma ONG que promove a educação criativa e transformadora. O sistema permite gerenciar eventos de forma prática e organizada, tanto na área pública quanto na área administrativa.

### Funcionalidades principais:

- Página institucional sobre a organização
- Sistema CRUD completo para eventos
- Páginas de login e cadastro
- Dashboard com visão gerencial

---

## 🚀 Funcionalidades

### 🔓 Páginas Públicas

- **Página Inicial:** Missão, visão, valores e projetos da ONG
- **Seção de Impacto:** Depoimentos e dados de impacto social
- **Área de Doações:** Para contribuições financeiras
- **Formulário de Contato:** Canal de comunicação com a organização

### 🔐 Área Logada

- **Dashboard:** Exibição de métricas e eventos cadastrados
- **Criar Evento:** 
  - Informações básicas, data, participantes e imagem
- **Editar Evento:** 
  - Seleção do evento e edição de dados
- **Excluir Evento:** 
  - Confirmação de exclusão com justificativa

---

## 🛠️ Tecnologias Utilizadas

- HTML5 semântico
- CSS3 com Flexbox e Grid
- JavaScript (ES6+)
- Design responsivo
- Font Awesome
- Google Fonts (Poppins, Roboto, Archivo)

---

## 📁 Estrutura de Arquivos

instituto-criativo/
├── public/
│ ├── images/
│ │ └── logo.png
├── src/
│ ├── auth/
│ │ ├── cadastro.html
│ │ ├── login.html
│ │ ├── styles.css
│ │ └── script.js
│ ├── dashboard/
│ │ ├── criar-evento.html
│ │ ├── editar-evento.html
│ │ ├── excluir-evento.html
│ │ ├── dashboard.html
│ │ ├── styles/
│ │ │ ├── criar-evento.css
│ │ │ ├── dashboard.css
│ │ │ ├── editar-evento.css
│ │ │ └── excluir-evento.css
│ │ └── scripts/
│ │ ├── criar-evento.js
│ │ ├── dashboard.js
│ │ ├── editar-evento.js
│ │ └── excluir-evento.js
│ └── pagina_inicial.html
├── README.md
└── index.html

## ▶️ Como Executar o Projeto

1. **Baixe e extraia os arquivos**
   - Faça o download do ZIP e extraia em uma pasta local.

2. **Acesse a página inicial**
   - Abra `pagina_inicial.html` no navegador.

3. **Área Logada**
   - Clique em "Área logada" no menu superior.
   - Use credenciais de teste (se necessário).
   
4. **Realize o login**
   - Preencha com seu email e senha.
   - Ou cadastre-se clicando no botão cadastrar-se.
     
5. **Navegue pelo Dashboard**
   - Veja métricas e eventos cadastrados.
   - Utilize o menu lateral para navegar.

6. **Criar Evento**
   - Clique em "Criar novo evento".
   - Preencha os campos obrigatórios (*).
   - Adicione participantes.
   - Selecione uma imagem.
   - Clique em "Publicar".

7. **Editar Evento**
   - Acesse "Editar evento".
   - Selecione um evento.
   - Edite os campos.
   - Clique em "Salvar Alterações".

8. **Excluir Evento**
   - Acesse "Excluir evento".
   - Selecione o evento.
   - Informe o motivo da exclusão.
   - Marque a confirmação.
   - Clique em "Publicar Exclusão".

> 💡 Todos os formulários possuem validação — campos com * são obrigatórios!
