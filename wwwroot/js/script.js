let modal = document.getElementById("ModalForm");
let openBtn = document.getElementById("modalbtn");
let closeBtn = document.getElementsByClassName("close")[0];

openBtn.onclick = function(){
    modal.style.display = "block";
}

closeBtn.onclick = function(){
    modal.style.display = "none";
}

window.onclick = function(event){
    if(event.target == modal){
        modal.style.display = "none";
    }
}