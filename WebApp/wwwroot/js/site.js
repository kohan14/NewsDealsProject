// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

const toggleButton = document.getElementsByClassName('toggle__button')[0]
const navbarLinks = document.getElementsByClassName('nav__links')[0]

toggleButton.addEventListener('click', () => {
    navbarLinks.classList.toggle('active')
})