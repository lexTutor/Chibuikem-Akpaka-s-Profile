// Open and close sidebar
let ul = null;
function openNav() {
    var c = document.getElementById("Sidebar");
    document.getElementById("Sidebar").style.width = "60%";
    document.getElementById("Sidebar").style.display = "block";

}

function closeNav() {
    document.getElementById("Sidebar").style.display = "none";
}

function ElementGetter(technoligies, projects, refrees) {
    ul = document.getElementById("listOfSkills");
    for (var i = 0; i < technoligies.length; i++) {
        value1 = technoligies[i][0];
        value2 = technoligies[i][1];
        let li = document.createElement("li");
        li.innerHTML = ` <li>
       <p class="w3-wide" id="Net">${value1}</p>
       <div class="w3-light-grey">
           <div class="w3-container w3-center w3-padding-small w3-dark-grey" style="width:${value2}">${value2}</div>
       </div>
        </li>`
        ul.append(li);
    }
    Array = ["blue", "blue-gray", "cyan", "aqua", "pale-blue", "blue-grey", "lime", "lemon", "purple", "deep-purple"]

    table = document.getElementById("ProjectTable");
    colorNumber = 0;
    for (var i = 0; i < projects.length; i++)
    {
        value3 = projects[i][0];
        value4 = projects[i][1];
        value5 = Array[colorNumber]
        let tableRow = document.createElement("tr");
        tableRow.className = `w3-hover-${value5}`;
        tableRow.innerHTML = ` <tr>
                        <td>${value3}</td>
                        <td><a href="${value4}" target ="_blank">To git-hub</a></td>
                    </tr>`
        table.append(tableRow);
        if (colorNumber == 9) {
            colorNumber = 0;
        }
        else {
            colorNumber++;
        }
    }

    refree = document.getElementById("Testimonials");
    for (var i = 0; i < refrees.length; i++)
    {
        value6 = refrees[i][0];
        //splitted = refrees[i][1].split(",")
        value7 = refrees[i][1];
        value8 = refrees[i][2];
        value9 = refrees[i][3];
        let image = document.createElement("img");
        image.src = value6;
        image.className = "w3-left w3-circle w3-margin-right";
        image.id = "ReputationImage";
        let ptag1 = document.createElement("p");
        let ptag2 = document.createElement("p");
        ptag1.innerHTML = `<p><span class="w3-large w3-text-black w3-margin-right">${value7}</span></p> <b>${value8}</b>`
        ptag2.innerHTML = ` <p>${value9}</p><br>`
        refree.append(image)
        refree.append(ptag1)
        refree.append(ptag2)
    }
    }