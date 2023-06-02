var skills1 = [
    { name: 'HTML', percentage: '100' },
    { name: 'CSS', percentage: '90' },
    { name: 'JavaScript', percentage: '75' },
    { name: 'Git', percentage: '95' },
    { name: 'Python', percentage: '66' },
    { name: 'React', percentage: '86' },
    { name: 'Bootstrap', percentage: '96' },
    { name: 'Visual Studio', percentage: '100' },
    { name: 'Dart', percentage: '70' }
];

var skills2 = [
    { name: 'PHP', percentage: '85' },
    { name: 'C#', percentage: '80' },
    { name: 'Java', percentage: '45' },
    { name: 'MySQLi', percentage: '75' },
    { name: 'SQL Serve', percentage: '84' },
    { name: '.NET', percentage: '90' },
    { name: 'Laravel', percentage: '98' },
    { name: 'Visual Studio Code', percentage: '100' },
    { name: 'Flutter', percentage: '40' }
];

function generateSkillSection(skills, containerId) {
    var container = document.getElementById(containerId);
    for (var i = 0; i < skills.length; i++) {
        var skill = skills[i];
        var skillElement = document.createElement('div');
        skillElement.className = 'progress';
        skillElement.innerHTML = `
            <span class="skill">${skill.name} <i class="val">${skill.percentage}%</i></span>
            <div class="progress-bar-wrap">
                <div class="progress-bar" role="progressbar" style="width: ${skill.percentage}%"></div>
            </div>
        `;
        container.appendChild(skillElement);
    }
}

generateSkillSection(skills1, 'skills1');
generateSkillSection(skills2, 'skills2');
