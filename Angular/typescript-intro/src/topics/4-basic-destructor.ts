interface AudioPlayer {
    audioVolume : number;
    songDuration: number
    song: string;
    details: Details;
}

interface Details {
    author: string;
    year: number;
}

const audioPlayer :AudioPlayer = {
    audioVolume: 90,
    songDuration: 36,
    song: 'Misery Business',
    details : {
        author: 'Hayley Williams',
        year: 2007
    }
}

console.log('sonh', audioPlayer.song);
console.log('duracion', audioPlayer.songDuration);
console.log('Audio Volume', audioPlayer.audioVolume);

const { song: anotherSong , songDuration : duracion , audioVolume}  = audioPlayer;
console.log ({anotherSong ,duracion, audioVolume})

const { author, year } = audioPlayer.details;
console.log ({ author, year})

const formula1: string[] =  ['Checo Perez', 'Max Verstappne', 'Sr.Lewis Hamilton'];

console.log('Tercero', formula1[3] || 'No Disponible');

const maxV = formula1[3] || 'No Encotrado';
console.log('Personaje 3', maxV)

//const [Checo, Max, Lewis]: string [] = ['Checo Perez', 'Max Verstappen', 'Lewis Hamilton'];
const [, , Lewis]: string [] = ['Checo Perez', 'Max Verstappen', 'Lewis Hamilton'];
console.log(Lewis)
export {};