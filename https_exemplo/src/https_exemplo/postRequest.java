package https_exemplo;
import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.nio.file.Path;
import java.time.Duration;

// NÃO ESTÁ FUNCIONANDO!!

public class postRequest {

	public static void main(String[] args) throws IOException, InterruptedException	{
		// TODO Auto-generated method stub
		
		final String URLGET = "https://jsonplaceholder.typicode.com/posts";
		final String FILEJSON=".\\getRequest.java";
		HttpClient client = HttpClient.newHttpClient();
		HttpRequest request = HttpRequest.newBuilder()
				.POST(HttpRequest.BodyPublishers.ofFile(Path.of(FILEJSON)))
				.timeout(Duration.ofSeconds(10))
				.uri(URI.create(URLGET))
				.build();
		
		client.sendAsync(request, HttpResponse.BodyHandlers.ofString())
			.thenApply(HttpResponse::body)
			.thenAccept(System.out::println)
			.join();
		
		//System.out.println(response.statusCode());
		//System.out.println(response.body());

	}

}
