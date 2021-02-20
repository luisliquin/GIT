interface ValidacionExitosa {
    esValido: true;
    reason: null
}

interface ValidacionFallida{
    esValido: false;
    reason: string;
}

type ResultadoValidacion = ValidacionExitosa | ValidacionFallida;

const result: ResultadoValidacion = {
    esValido: true,
    reason: null
}

export default{}