type Person = {
    firstName: string; 
    lastName: string;
}

type Client = {
    clientNumber: number;
}

type NewClient = Person & Client;

//const x: NewClient;