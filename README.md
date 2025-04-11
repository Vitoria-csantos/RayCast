<h1>Atividade do RayCast</h1>

<h2>Proposta</h2>
<p>Decidimos fazer uma cena onde o Raycast é utilizado no clique do mouse. Na cena, os objetos a serem atingidos são três esferas que serão destruídas. Tais esferas são marcadas com a tag "target" pelo próprio Unity. </p>

<h2>Código</h2>
<p>Fora dos voids e dentro da classe "raio" as variáveis foram declaradas, as próprias variáveis do Raycast (ray e RayCast Hit), uma variável de cor e um Vector 2, pois o raio só tem dois eixos, logo, não é 3D.</p>
<br>
<p>Logo após, a primeira variável do código é declarada, para indicar que o ray será lançado a partir do clique do mouse. Nessa mesma condicional, é definido que o mouse aponta o ray e a cor dele (por algum motivo não apareceu na cena).</p>
<p>Na segunda condicional, um Physics.Raycast é lançando, disparando o raio até o ponto selecionado e retornando um dado. No código, é retornado uma mensagem em Debug.Log dizendo "Start!" e um dado em hitdata relacionado ao GameObject.</p>
<p>Por fim, na última condicional, é dito que, caso o objeto com a tag "target" seja atingido, ele será destruído.</p>

<h2>Divisão do trabalho</h2>
<p>Ambas fizemos tanto a programação quanto a parte visual da cena.</p>
