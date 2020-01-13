var wavesurfer = new WaveSurfer.create({
    container: '#player',
    barWidth: 3,
    waveColor: '#eee',
    progressColor: '#2980B9',
    barWidth: 8,
    barRadius: true,
    height: 196
});

var isPlaying = false;
function play() {
    isPlaying = !isPlaying;

    var buttonClass = (isPlaying) ? "fas fa-pause" : "fas fa-play";
    document.getElementById('togglePlay').className = buttonClass;

    wavesurfer.playPause();
}

var isMuted = false;
function toggleMute() {
    isMuted = !isMuted;

    var buttonClass = (isMuted) ? "fas fa-volume-mute" : "fas fa-volume-up";
    document.getElementById('toggleMute').className = buttonClass;

    wavesurfer.setMute(isMuted);
}

var loadedMusic = "";
function loadMusic() {
    var select = document.getElementById('music-select');
    var newSong = select.options[select.selectedIndex].text;

    wavesurfer.load("/audio/" + newSong);

    wavesurfer.on('ready', function () {
        document.getElementById('song-name').innerHTML = "<i> Playing : </i>" + newSong;

        if (isPlaying) {
            wavesurfer.play();
        }
    });
}

function musicNext() {
    var select = document.getElementById('music-select');

    // Get max array position 
    var selectLength = select.length - 1;

    var currentSongId = select.options.selectedIndex;

    var nextSongId = currentSongId + 1;
    if (nextSongId > selectLength) {
        nextSongId = 0;
    }

    select.options[nextSongId].selected = "selected";

    loadMusic();
}

function musicPrev() {
    var select = document.getElementById('music-select');

    // Get max array position 
    var selectLength = select.length - 1;

    var currentSongId = select.options.selectedIndex;

    var prevSongId = currentSongId - 1;
    if (prevSongId < 0) {
        prevSongId = selectLength;
    }

    select.options[prevSongId].selected = "selected";

    loadMusic();
}

function musicRandom() {
    var select = document.getElementById('music-select');
     
    var selectLength = select.length;

    var currentSongId = select.options.selectedIndex;

    var random = currentSongId;
    while (random == currentSongId) {
        random = Math.floor(Math.random() * (selectLength));
    }

    select.options[random].selected = "selected";

    loadMusic();
}

// Loads a song by default
loadMusic();