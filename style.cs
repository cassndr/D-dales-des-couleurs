/* Base de Couleurs et Typographie */
:root {
--color-dark: #1e1e1e; /* Fond principal (très foncé) */
--color-gold: #d4af37; /* Couleur Or/Jaune (pour les barres et titres) */
--color-text-light: #f4f4f4; /* Texte clair sur fond foncé */
--color-text-dark: #333; /* Texte sombre (pour les liens sur fond gold) */
--color-image-bg: #ccc; /* Fond gris clair pour les cadres d'images */
}

/* Réinitialisation de base et styles Mobile-First */
* {
margin: 0;
padding: 0;
box-sizing: border-box;
scroll-behavior: smooth;
}
body {
font-family: 'Roboto', sans-serif;
background-color: var(--color-dark);
color: var(--color-text-light);
line-height: 1.6;
text-align: center;
min-width: 320px;
}
h1, h2, h3 {
font-family: 'Playfair Display', serif;
font-weight: 700;
}
/* --- Styles du HEADER, NAV, TITRES (inchangés) --- */
.site-header { padding: 20px 0 10px; }
.logo { width: 150px; height: auto; display: block; margin: 0 auto; }
.main-title { color: var(--color-gold); text-decoration: underline; font-size: 2.2em;
margin-bottom: 5px; }
.main-subtitle { font-style: italic; font-weight: 300; font-size: 1.1em; margin-bottom: 20px; }
.main-nav { display: flex; flex-direction: column; background-color: var(--color-gold);
font-family: 'Playfair Display', serif; font-size: 1.1em; }
.nav-item { color: var(--color-dark); text-decoration: none; padding: 15px 10px; flex-grow: 1;
transition: background-color 0.3s; }
.separator { display: none; }
.section-title { background-color: var(--color-gold); padding: 15px 10px; margin: 30px 0;
width: 100%; }
.section-title h2 { color: var(--color-dark); font-size: 1.8em; text-decoration: underline; }

.content-image, .artwork-image, .poster-image {
width: 100%;
height: 100%;
object-fit: cover; /* Assure que l'image couvre le cadre sans déformation excessive */
display: block;
}
.image-container, .image-wrapper, .poster-wrapper {

position: relative;
background-color: var(--color-image-bg);
}
.image-container img, .image-wrapper img, .poster-wrapper img {
position: absolute;
top: 0;
left: 0;
}
/* Image 1 (Galerie, Grande) : Ajusté pour être plus large que haut */
.aspect-ratio-1 { padding-top: 45%; width: 90%; margin: 0 auto 20px; }
/* Image 2 (Galerie, Petite) : Ajusté pour être moins large que haut */

.aspect-ratio-2 { 
    padding-top: 60%; 
    width: 90%; 
    margin: 20px auto; 
}
/* Oeuvre 1 (Grande) : Ajusté pour être plus carré */
.large-wrapper { 
    padding-top: 60%; 
    width: 90%; 
    margin: 0 auto 10px; 
}
/* Oeuvres 2, 3, 4 (Petites) : Carré */
.small-wrapper { 
    padding-top: 100%; 
}
/* Oeuvres 5, 6 (Moyennes) : Ajusté pour être légèrement plus haut que large */
.medium-wrapper-5, 
.medium-wrapper-6 { 
    padding-top: 65%; 
}
/* Affiches (Verticales) : Ajusté pour être plus grand/étroit (type poster) */
.poster-wrapper { 
    padding-top: 170%; 
}

/* --- Reste du CSS (inchangé) --- */
.gallery-content { 
    padding: 0 5%; 
}
.gallery-block { 
    margin-bottom: 40px; 
}
.text-block { 
    text-align: left; 
    padding: 10px; 
    font-size: 0.95em; 
}
.artwork-item { 
    margin-bottom: 30px; 
}
.artwork-name { 
    margin-top: 5px; 
    font-weight: 400; 
    font-size: 0.9em; 
}
.row-small-artworks, 
.row-medium-artworks { 
    display: flex; 
    flex-direction: column; 
    gap: 30px;
    margin-bottom: 30px; 
}
.poster-grid { 
    padding: 0 5%; 
    margin-bottom: 50px; 
}
.poster-item { 
    margin-bottom: 30px; 
}

.site-footer { 
    background-color: #111; 
    padding: 40px 5%; 
    border-top: 3px solid var(--color-gold); 
    text-align: left; 
}
.footer-content { 
    display: flex; 
    flex-direction: column; 
    gap: 30px; 
}
.footer-title { 
    color: var(--color-gold); 
    font-size: 1.4em; 
    margin-bottom: 15px; 
    text-decoration: underline; 
}
.contact-form { 
    display: flex; 
    flex-direction: column; 
    gap: 10px; 
}
.contact-form input[type="email"] { 
    padding: 10px; 
    border: 1px solid var(--color-gold);
    background-color: var(--color-dark); 
    color: var(--color-text-light); 
    font-size: 1em; 
}
.contact-form button { 
    padding: 10px; 
    background-color: var(--color-gold); 
    color: var(--color-dark); 
    border: none; 
    cursor: pointer; 
    font-weight: bold; 
    transition: background-color 0.3s; 
}
.contact-form button:hover { 
    background-color: #e6c05d; 
}
.contributors-container p { 
    margin: 5px 0; 
    font-size: 0.9em; 
}
.copyright { 
    text-align: center; 
    color: #666; 
    margin-top: 30px; 
    font-size: 0.8em; 
}

@media (min-width: 768px) {
    .main-nav { 
        flex-direction: row; 
        border-top: 1px solid var(--color-gold); 
        border-bottom: 1px solid var(--color-gold); 
    }
    .separator { 
        display: block; 
        align-self: stretch; 
        width: 1px; 
        background-color: var(--color-dark); 
    }
    .nav-item { 
        padding: 20px 0; 
    }
    .gallery-content { 
        max-width: 1100px; 
        margin: 0 auto; 
        padding: 0 30px; 
    }
    .gallery-block { 
        display: flex; 
        align-items: center; 
        text-align: left; 
    }
    .block-top { 
        flex-direction: row; 
    }
    .block-bottom { 
        flex-direction: row-reverse; 
    }
    .image-container { 
        width: 50%; 
        margin: 0; 
    }
    .text-block { 
        width: 50%; 
        padding: 0 20px; 
    }
    .block-top .text-block { 
        padding-left: 20px; 
        padding-right: 0; 
    }
    .block-bottom .text-block { 
        padding-right: 20px; 
        padding-left: 0; 
        text-align: right; 
    }
    .block-top .image-container { 
        margin-right: 20px; 
    }
    .block-bottom .image-container { 
        margin-left: 20px; 
    }
    .artworks-grid { 
        max-width: 1200px; 
        margin: 0 auto; 
        padding: 0 30px; 
    }
    .artwork-large { 
        max-width: 800px; 
        margin: 0 auto 50px; 
    }
    .row-small-artworks { 
        flex-direction: row; 
        gap: 3%; 
        margin-bottom: 50px; 
    }
    .artwork-small { 
        width: 31.33%; 
    }
    .row-medium-artworks { 
        flex-direction: row; 
        justify-content: center; 
        gap: 5%;
        margin-bottom: 50px; 
    }
    .artwork-medium { 
        width: 47.5%; 
        max-width: 500px; 
    }
    .poster-grid { 
        display: flex; 
        justify-content: center; 
        gap: 30px; 
        padding: 0 30px; 
        max-width: 1200px; 
    }
    .poster-item { 
        width: 30%; 
        max-width: 300px; 
    }
    /* FOOTER DESKTOP */
    .footer-content { 
        flex-direction: row; 
        justify-content: space-around; 
        gap: 50px; 
        max-width: 1200px; 
        margin: 0 auto; 
        text-align: left; 
    }
    .contact-form-container, 
    .contributors-container { 
        width: 40%; 
    }
    .contact-form { 
        flex-direction: row; 
        gap: 5px; 
    }
    .contact-form input[type="email"] { 
        flex-grow: 1; 
    }
    .contact-form button {
        width: 120px; 
    }
}
